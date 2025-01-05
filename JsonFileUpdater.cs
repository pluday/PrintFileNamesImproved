using System;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;
using PrintFileNames;
using System.Xml.Linq;

public class JsonFileUpdater
{
    public void ConvertFormsArray(string filePath)
    {
        // Read the JSON file into a string
        string json = File.ReadAllText(filePath);

        // Deserialize the JSON string into an array
        //dynamic[] dataArray = JsonConvert.DeserializeObject<dynamic[]>(json);
        List<dynamic> dataList = JsonConvert.DeserializeObject<List<dynamic>>(json);


        // Loop through each item in the array and update the JSON data
        foreach (dynamic data in dataList)
        {
            var allPaths = data["forms"];
            int idx = 1;
            foreach (string value in allPaths)
            {
                // Create the nested object
                dynamic nestedObject = new
                {
                    id = idx,
                    form = Path.GetFileName(Path.GetDirectoryName(value)),
                    path = value
                };

                // Add the nested object to the objects array
                if (data.forms == null)
                    data.forms = new List<dynamic>();

                data.forms.Add(nestedObject);
                idx++;
            }
        }
        // Serialize the updated JSON data back to a string
        string updatedJson = JsonConvert.SerializeObject(dataList, Formatting.Indented);

        // Write the updated JSON string back to the file
        File.WriteAllText(filePath, updatedJson);

    }

    public async Task WriteShasanaFile(string[] files, string outputPath, string FileDirectory)
    {
        JArray jsonArray = GetJsonArray(outputPath);

        foreach (string fullPath in files)
        {
            string result = Path.GetFileNameWithoutExtension(fullPath);
            if (result == "letter_missing") continue;

            string filePath = Path.GetRelativePath(FileDirectory, fullPath);
            filePath = filePath.Replace("\\", "/");

            int underscoreCount = result.Count(c => c == '_');

            if (underscoreCount == 5)
            {
                try
                {
                    int indx1 = result.IndexOf('_');
                    int indx2 = result.IndexOf('_', indx1 + 1);
                    int indx3 = result.IndexOf('_', indx2 + 1);
                    int indx4 = result.IndexOf('_', indx3 + 1);
                    int indx5 = result.IndexOf('_', indx4 + 1);

                    int year = Convert.ToInt16(result[..indx1]);
                    string encoding = result[(indx1 + 1)..indx2];
                    string place = result[(indx2 + 1)..indx3];
                    int lineNumber = Convert.ToInt16(result[(indx3 + 1)..indx4]);
                    int posNumber = Convert.ToInt16(result[(indx4 + 1)..indx5]);
                    string letter = result[(indx5 + 1)..];

                    string kannadaWord =  Aksharamukha.ConvertIASTtoKannada(letter);

                    JObject newItem = new()
                    {
                        ["id"] = jsonArray.Count + 1,
                        ["year"] = year,
                        ["encoding"] = encoding,
                        ["place"] = place,
                        ["lineNumber"] = lineNumber,
                        ["posNumber"] = posNumber,
                        ["letter"] = letter,
                        ["fileName"] = result,
                        ["filePath"] = filePath,
                        ["kannadaWord"] = kannadaWord
                    };

                    // Add the new item to the JArray
                    jsonArray.Add(newItem);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(result + " file could not be transformed");
                }


            }
            else
            {
                Console.WriteLine(result + " file could not be transformed");

            }
            //string shilasanName = result[..indx3].Replace('_', ' ');

        }

        // Convert the JArray back to JSON
        if (jsonArray.Count > 0)
        {
            string updatedJson = jsonArray.ToString(Formatting.Indented);

            // Write the updated JSON back to the file
            File.WriteAllText(outputPath, updatedJson);

            Console.WriteLine(outputPath + " file updated successfully\n");
        }

    }

    private JArray GetJsonArray(string filePath)
    {
        JArray jsonArray;

        if (File.Exists(filePath))
        {
            // Read the existing JSON file contents
            string json = File.ReadAllText(filePath);

            if (string.IsNullOrEmpty(json))
            {
                jsonArray = new JArray();
            }
            else
            {
                // Parse the JSON array into a JArray
                jsonArray = JArray.Parse(json);
            }
        }
        else
        {
            // Create a new JArray if the file doesn't exist
            jsonArray = new JArray();
        }
        return jsonArray;
    }

    public Dictionary<string, string> ReadJsonFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            // Read the JSON file contents
            string json = File.ReadAllText(filePath);

            // Deserialize the JSON array into a list of dynamic objects
            var jsonArray = JsonConvert.DeserializeObject<dynamic[]>(json);

            // Create a dictionary to store the key-value pairs
            var dictionary = new Dictionary<string, string>();

            foreach (var item in jsonArray)
            {
                string iastForm = item.IASTform;
                string key = item.key;

                // Add the key-value pair to the dictionary
                dictionary[iastForm] = key;
            }

            return dictionary;
        }
        else
        {
            Console.WriteLine("The specified JSON file does not exist.");
            return null;
        }
    }

    private IEnumerable<object> GroupForms(List<string> forms)
    {


        var results = forms.GroupBy(
                p => Path.GetFileName(Path.GetDirectoryName(p)),
                p => p,
                (key, g) => new { form_num = "ರೂಪಾ " + key[-1], forms = g.ToList() });

        return results;
    }

    private int GetYearFromPath(string path)
    {
        try
        {
            string fileName = Path.GetFileNameWithoutExtension(path);
            int indx1 = fileName.IndexOf('_');
            int year = Convert.ToInt16(fileName[..indx1]);
            return year;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Could not find year in: " + path);
            return -1;
        }

    }

    public void ClearJsonFile(string filePath, bool printOutput = true)
    {
        File.WriteAllText(filePath, string.Empty);
        string fileName = Path.GetFileName(filePath);
        if (printOutput)
        {
            Console.WriteLine(fileName + " : contents cleared");
        }
    }

    public void UpdateJsonFileFormsArray(string filePath, string key, List<string> forms, string IASTvalue = "", bool printFinalOutput = false)
    {

        //var groupedforms = GroupForms(forms);

        JArray jsonArray;

        if (File.Exists(filePath))
        {
            // Read the existing JSON file contents
            string json = File.ReadAllText(filePath);

            if (string.IsNullOrEmpty(json))
            {
                jsonArray = new JArray();
            }
            else
            {
                // Parse the JSON array into a JArray
                jsonArray = JArray.Parse(json);
            }
        }
        else
        {
            // Create a new JArray if the file doesn't exist
            jsonArray = new JArray();
        }

        // Find the item with the matching key
        JObject item = jsonArray.FirstOrDefault(x => x["key"].Value<string>() == key) as JObject;

        if (item != null)
        {
            if (forms.Count > 0)
            {
                int idx = 1;
                JArray formsArray = new();

                foreach (var path in forms)
                {
                    JObject newFormObject = new()
                    {
                        ["id"] = idx,
                        ["form"] = Path.GetFileName(Path.GetDirectoryName(path)),
                        ["path"] = path,
                        ["year"] = GetYearFromPath(path)
                    };
                    formsArray.Add(newFormObject);
                    idx++;
                }

                item["letterForms"] = formsArray;
                item["forms"] = new JArray();

                // Update the "forms" property with the provided array of strings
                //item["forms"] = JArray.FromObject(forms);
            }
            else
            {
                item["isAvailable"] = false;
            }
        }
        else
        {
            int idx = 1;
            JArray formsArray = new();

            foreach (var path in forms)
            {
                JObject newFormObject = new()
                {
                    ["id"] = idx,
                    ["form"] = Path.GetFileName(Path.GetDirectoryName(path)),
                    ["path"] = path,
                    ["year"] = GetYearFromPath(path)
                };
                formsArray.Add(newFormObject);
                idx++;
            }

            // Create a new item with the specified key and forms
            JObject newItem = new()
            {
                ["id"] = jsonArray.Count + 1,
                ["key"] = key,
                ["isAvailable"] = forms.Count > 0,
                //["forms"] = JArray.FromObject(forms),
                ["letterForms"] = formsArray,
                ["IASTform"] = IASTvalue // Modify as needed
            };

            // Add the new item to the JArray
            jsonArray.Add(newItem);
        }

        // Convert the JArray back to JSON
        string updatedJson = jsonArray.ToString(Formatting.Indented);

        // Write the updated JSON back to the file
        File.WriteAllText(filePath, updatedJson);

        if (printFinalOutput)
        {
            Console.WriteLine(filePath + " file updated successfully.");
        }
    }

    //generates a 7 digit random number
    int GenerateRandomNumber(List<int> inputList)
    {
        Random random = new Random();
        int randomNumber = random.Next(1000000, 9999999);

        while (inputList.Contains(randomNumber))
        {
            randomNumber = random.Next(1000000, 9999999);
        }

        return randomNumber;
    }

    public void UpdateShasanasJson(string filePath, List<string> forms)
    {
        JArray jsonArray;

        if (File.Exists(filePath))
        {
            // Read the existing JSON file contents
            string json = File.ReadAllText(filePath);

            if (string.IsNullOrEmpty(json))
            {
                jsonArray = new JArray();
            }
            else
            {
                // Parse the JSON array into a JArray
                jsonArray = JArray.Parse(json);
            }
        }
        else
        {
            // Create a new JArray if the file doesn't exist
            jsonArray = new JArray();
        }

        var inscriptionIds = jsonArray.Select(x => x["id"].Value<int>()).ToList();



        foreach (var name in forms)
        {
            JObject item = jsonArray.FirstOrDefault(x => x["key"].Value<string>() == name) as JObject;

            if (item == null)
            {
                int year = GetYearFromPath(name);
                int inscriptionId = GenerateRandomNumber(inscriptionIds);
                string inscriptionName = name.Replace("_", " ");
                JObject newFormObject = new()
                {
                    ["id"] = inscriptionId,
                    ["displayName"] = inscriptionName,
                    ["imagePath"] = string.Empty,
                    ["description"] = string.Empty,
                    ["links"] = new JArray(),
                    ["year"] = year,
                    ["key"] = name
                };

                jsonArray.Add(newFormObject);
                Console.WriteLine(name + " added with id "+ inscriptionId + "\n");

            }
            else
            {
                Console.WriteLine(name + " already exists in the shasanas.json file and is not modified\n");
            }
        }

        // Convert the JArray back to JSON
        string updatedJson = jsonArray.ToString(Formatting.Indented);

        // Write the updated JSON back to the file
        File.WriteAllText(filePath, updatedJson);

    }
}
