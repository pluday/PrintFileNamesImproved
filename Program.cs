// See https://aka.ms/new-console-template for more information
using PrintFileNames;
using PrintFileNames.Mappings;
using System.Text;
using System.Text.RegularExpressions;
using Python.Runtime;


Environment.SetEnvironmentVariable("PYTHONNET_PYTHONHOME", @"C:\Users\Uday\AppData\Local\Programs\Python\Python313\");
Environment.SetEnvironmentVariable("PYTHONNET_PYTHONDLL", @"C:\Users\Uday\AppData\Local\Programs\Python\Python313\python313.dll");


Console.OutputEncoding = Encoding.UTF8; // Set the console's output encoding to UTF-8
Console.InputEncoding = Encoding.Unicode;
string lastUpdatedDate = "14-10-2023";

string RootDirectory, FileDirectory, JSONDirectory, ShasanasImagesDirectory;
string toolTitle = "KANNADA LETTERS CONFIGURATION TOOL (AKSHARABHANDARA SOFTWARE)\nLast updated on"+ lastUpdatedDate +"\n";
Console.WriteLine(toolTitle);

while (true)
{
    RootDirectory = GetFilePath();
    FileDirectory = RootDirectory + "\\Kannada_Characters";
    JSONDirectory = RootDirectory + "\\json\\";
    ShasanasImagesDirectory = RootDirectory + "\\Shasanas\\";

    if (!Directory.Exists(FileDirectory) || !Directory.Exists(JSONDirectory) || !Directory.Exists(ShasanasImagesDirectory))
    {
        Console.Error.WriteLine("One of the required sub folders is missing in the folder path that you've entered.");
        Console.WriteLine("Enter the correct path to the public assets folder\n");
    }
    else
    {
        break;
    }
}

string headPrompt = "Before running any of the below action, update the ..public/assets/Kannada_Characters folder with images of the letters.\n" +
    "Also update the ..public/assets/Shasanas folder with images of the inscriptions\n\n";

string description = "Below is list of actions - each action updates a corresponding .json configuration files in the ..public/assets/json folder\n";
//"NOTE: The actions below will only append to the existing json files and does not modify existing data\n";

string prompt = "Enter the number associated with the update action that you want to perform\n" +
"1: Swara and Vynajana, Numbers, Gunitakshara, Samyuktakshara\n" +
"2: All Inscriptions\n" +
"3: Inscription by name\n" +
//"7: Verfiy image names\n" +
"0: to quit and close\n";

Console.WriteLine(headPrompt + description + prompt);

while (true)
{
    Console.WriteLine("Enter action number:");
    string actionNumber = Console.ReadLine();
    int type = Convert.ToInt32(actionNumber);

    switch (type)
    {
        //case 0:
        //    GetSymbols();
        //    break;
        //case 6:
        //    //gets all folder names and converts them into kannada characters and writes into csv
        //    await TranslateFolderNamesToKannadaAsync();
        //    break;

        //case 5:

        //SamyuktaksharaReader(JSONDirectory + "samyuktakshara\\letters.json");
        //break;

        //case 3:
        //    ConvertForms();
        //    break;
        case 999:
            //loops through kannada alphabets - swara and vynajana
            Console.WriteLine("Update the letters.json file in the 'json' folder");
            LettersRun();
            break;
        case 2514:
            Console.WriteLine("Update the vyanjana .json files in the json/gunitakshara folder");
            GunitaksharaRunLetter("ಱ");
            break;
        case 5025:
            Console.WriteLine("Update the vyanjana .json files in the json/gunitakshara folder");
            GunitaksharaRun();
            break;
        case 1897:
            Console.WriteLine("Updating the samyuktakshara\\allLetters.json json file");
            await GetAllSamyuktaksharaAsync();
            break;
        case 1:
            //loops through kannada alphabets - swara and vynajana
            Console.WriteLine("Update the letters.json file in the 'json' folder");
            LettersRun();
            Console.WriteLine("-----------------------------------------------------/n");

            Console.WriteLine("Update the numbers.json file in the 'json' folder");
            NumbersRun();
            Console.WriteLine("-----------------------------------------------------/n");

            //loop through vyanjanas and their gunita forms - and update each vyanjana.json file
            Console.WriteLine("Update the vyanjana .json files in the json/gunitakshara folder");
            GunitaksharaRun();
            Console.WriteLine("-----------------------------------------------------/n");

            Console.WriteLine("Update the symbols.json");
            GetSymbols();
            Console.WriteLine("-----------------------------------------------------/n");

            Console.WriteLine("Updating the samyuktakshara\\allLetters.json json file");
            await GetAllSamyuktaksharaAsync();
            break;

        //case 4:
        //    //loop through vyanjanas and their samyukta forms - and update each vyanjana.json file
        //    //SamyuktaksharaRun();
        //    Console.WriteLine("Update the vyanjana .json files in the json/samyuktakshara folder");
        //    break;

        case 2:
            //create a json file for each shasana, with letters, line and position number of each character in them
            Console.WriteLine("Update the shasanas.json file in the 'json' folder & inscription-key.json file in the json/shasanas folder");
            await GetShasanaDetails();
            break;
        case 0:
            break;

        case 3:
            Console.WriteLine("Enter the inscription name in this format ex: 1329_IthDar_Kadatanamale, 900_CP204_Malurpatna");
            string inscriptionName = Console.ReadLine();
            JsonFileUpdater fileUpdater = new();
            await UpdateInscriptionFile(fileUpdater, inscriptionName);

            break;
        //case 7:
        //    VerifyImageNames();
        //    break;
        default:
            Console.WriteLine("Unavailable action");
            break;
            //case 10:
            //    GetKannadaRootLetter("kai");
            //    break;

    }
    if (type == 0)
    {
        Console.WriteLine("End");
        break;
    }
    Console.WriteLine("");
    Console.WriteLine("===========================================================");
}

async Task GetAllSamyuktaksharaAsync()
{
    List<string> allIASTforms = new()
    {
        "1","2","3","4","5","6","7","8","9","0","Symbols",
            "a", "ā", "i", "ī", "u", "ū", "ṛ", "ṝ", "ĕ", "e", "ai", "ŏ", "o", "au", "aṃ", "aḥ",
            "ka", "kā", "ki", "kī", "ku", "kū", "kṛ", "kṝ", "kĕ", "ke", "kai", "kŏ", "ko", "kau", "kaṃ", "kaḥ", "k",
            "kha", "khā", "khi", "khī", "khu", "khū", "khṛ", "khṝ", "khĕ", "khe", "khai", "khŏ", "kho", "khau", "khaṃ", "khaḥ", "kh",
            "ga", "gā", "gi", "gī", "gu", "gū", "gṛ", "gṝ", "gĕ", "ge", "gai", "gŏ", "go", "gau", "gaṃ", "gaḥ", "g",
            "gha", "ghā", "ghi", "ghī", "ghu", "ghū", "ghṛ", "ghṝ", "ghĕ", "ghe", "ghai", "ghŏ", "gho", "ghau", "ghaṃ", "ghaḥ", "gh",
            "ṅa", "ṅā", "ṅi", "ṅī", "ṅu", "ṅū", "ṅṛ", "ṅṝ", "ṅĕ", "ṅe", "ṅai", "ṅŏ", "ṅo", "ṅau", "ṅaṃ", "ṅaḥ", "ṅ",
            "ca", "cā", "ci", "cī", "cu", "cū", "cṛ", "cṝ", "cĕ", "ce", "cai", "cŏ", "co", "cau", "caṃ", "caḥ","c",
            "cha", "chā", "chi", "chī", "chu", "chū", "chṛ", "chṝ", "chĕ", "che", "chai", "chŏ", "cho", "chau", "chaṃ", "chaḥ", "ch",
            "ja", "jā", "ji", "jī", "ju", "jū", "jṛ", "jṝ", "jĕ", "je", "jai", "jŏ", "jo", "jau", "jaṃ", "jaḥ", "j",
            "jha", "jhā", "jhi", "jhī", "jhu", "jhū", "jhṛ", "jhṝ", "jhĕ", "jhe", "jhai", "jhŏ", "jho", "jhau", "jhaṃ", "jhaḥ", "jh",
            "ña", "ñā", "ñi", "ñī", "ñu", "ñū", "ñṛ", "ñṝ", "ñĕ", "ñe", "ñai", "ñŏ", "ño", "ñau", "ñaṃ", "ñaḥ", "ñ",
            "ṭa", "ṭā", "ṭi", "ṭī", "ṭu", "ṭū", "ṭṛ", "ṭṝ", "ṭĕ", "ṭe", "ṭai", "ṭŏ", "ṭo", "ṭau", "ṭaṃ", "ṭaḥ", "ṭ",
            "ṭha", "ṭhā", "ṭhi", "ṭhī", "ṭhu", "ṭhū", "ṭhṛ", "ṭhṝ", "ṭhĕ", "ṭhe", "ṭhai", "ṭhŏ", "ṭho", "ṭhau", "ṭhaṃ", "ṭhaḥ", "ṭh",
            "ḍa", "ḍā", "ḍi", "ḍī", "ḍu", "ḍū", "ḍṛ", "ḍṝ", "ḍĕ", "ḍe", "ḍai", "ḍŏ", "ḍo", "ḍau", "ḍaṃ", "ḍaḥ", "ḍ",
            "ḍha", "ḍhā", "ḍhi", "ḍhī", "ḍhu", "ḍhū", "ḍhṛ", "ḍhṝ", "ḍhĕ", "ḍhe", "ḍhai", "ḍhŏ", "ḍho", "ḍhau", "ḍhaṃ", "ḍhaḥ", "ḍ",
            "ṇa", "ṇā", "ṇi", "ṇī", "ṇu", "ṇū", "ṇṛ", "ṇṝ", "ṇĕ", "ṇe", "ṇai", "ṇŏ", "ṇo", "ṇau", "ṇaṃ", "ṇaḥ", "ṇ",
            "ta", "tā", "ti", "tī", "tu", "tū", "tṛ", "tṝ", "tĕ", "te", "tai", "tŏ", "to", "tau", "taṃ", "taḥ", "t",
            "tha", "thā", "thi", "thī", "thu", "thū", "thṛ", "thṝ", "thĕ", "the", "thai", "thŏ", "tho", "thau", "thaṃ", "thaḥ", "th",
            "da", "dā", "di", "dī", "du", "dū", "dṛ", "dṝ", "dĕ", "de", "dai", "dŏ", "do", "dau", "daṃ", "daḥ", "d",
            "dha", "dhā", "dhi", "dhī", "dhu", "dhū", "dhṛ", "dhṝ", "dhĕ", "dhe", "dhai", "dhŏ", "dho", "dhau", "dhaṃ", "dhaḥ", "dh",
            "na", "nā", "ni", "nī", "nu", "nū", "nṛ", "nṝ", "nĕ", "ne", "nai", "nŏ", "no", "nau", "naṃ", "naḥ", "n",
            "pa", "pā", "pi", "pī", "pu", "pū", "pṛ", "pṝ", "pĕ", "pe", "pai", "pŏ", "po", "pau", "paṃ", "paḥ", "p",
            "pha", "phā", "phi", "phī", "phu", "phū", "phṛ", "phṝ", "phĕ", "phe", "phai", "phŏ", "pho", "phau", "phaṃ", "phaḥ", "ph",
            "ba", "bā", "bi", "bī", "bu", "bū", "bṛ", "bṝ", "bĕ", "be", "bai", "bŏ", "bo", "bau", "baṃ", "baḥ", "b",
            "bha", "bhā", "bhi", "bhī", "bhu", "bhū", "bhṛ", "bhṝ", "bhĕ", "bhe", "bhai", "bhŏ", "bho", "bhau", "bhaṃ", "bhaḥ", "bh",
            "ma", "mā", "mi", "mī", "mu", "mū", "mṛ", "mṝ", "mĕ", "me", "mai", "mŏ", "mo", "mau", "maṃ", "maḥ", "m",
            "ya", "yā", "yi", "yī", "yu", "yū", "yṛ", "yṝ", "yĕ", "ye", "yai", "yŏ", "yo", "yau", "yaṃ", "yaḥ", "y",
            "ra", "rā", "ri", "rī", "ru", "rū", "rṛ", "rṝ", "rĕ", "re", "rai", "rŏ", "ro", "rau", "raṃ", "raḥ", "r",
            "ṟa", "ṟā", "ṟi", "ṟī", "ṟu", "ṟū", "ṟṛ", "ṟṝ", "ṟĕ", "ṟe", "ṟai", "ṟŏ", "ṟo", "ṟau", "ṟaṃ", "ṟaḥ", "ṟ",
            "la", "lā", "li", "lī", "lu", "lū", "lṛ", "lṝ", "lĕ", "le", "lai", "lŏ", "lo", "lau", "laṃ", "laḥ", "l",
            "va", "vā", "vi", "vī", "vu", "vū", "vṛ", "vṝ", "vĕ", "ve", "vai", "vŏ", "vo", "vau", "vaṃ", "vaḥ", "v",
            "śa", "śā", "śi", "śī", "śu", "śū", "śṛ", "śṝ", "śĕ", "śe", "śai", "śŏ", "śo", "śau", "śaṃ", "śaḥ", "ś",
            "ṣa", "ṣā", "ṣi", "ṣī", "ṣu", "ṣū", "ṣṛ", "ṣṝ", "ṣĕ", "ṣe", "ṣai", "ṣŏ", "ṣo", "ṣau", "ṣaṃ", "ṣaḥ", "ṣ",
            "sa", "sā", "si", "sī", "su", "sū", "sṛ", "sṝ", "sĕ", "se", "sai", "sŏ", "so", "sau", "saṃ", "saḥ", "s",
            "ha", "hā", "hi", "hī", "hu", "hū", "hṛ", "hṝ", "hĕ", "he", "hai", "hŏ", "ho", "hau", "haṃ", "haḥ", "h",
            "l̤a", "l̤ā", "l̤i", "l̤ī", "l̤u", "l̤ū", "l̤ṛ", "l̤ṝ", "l̤ĕ", "l̤e", "l̤ai", "l̤ŏ", "l̤o", "l̤au", "l̤aṃ", "l̤aḥ", "l̤",
            "ḻa", "ḻā", "ḻi", "ḻī", "ḻu", "ḻū", "ḻṛ", "ḻṝ", "ḻĕ", "ḻe", "ḻai", "ḻŏ", "ḻo", "ḻau", "ḻaṃ", "ḻaḥ", "ḻ",
        };


    Directory.SetCurrentDirectory(FileDirectory);

    if (Directory.Exists(FileDirectory))
    {
        JsonFileUpdater jsonFileUpdater = new();

        List<string> folderPaths = Directory.GetDirectories(FileDirectory, "*", SearchOption.TopDirectoryOnly).ToList();

        var samyuktaForms = folderPaths.Where(path => !allIASTforms.Contains(Path.GetFileName(path))).ToList();

        string lettersPath = JSONDirectory + "samyuktakshara\\allLetters.json";
        jsonFileUpdater.ClearJsonFile(lettersPath);

        foreach (var samyuktaFilePath in samyuktaForms)
        {
            string lastFolderName = Path.GetFileNameWithoutExtension(samyuktaFilePath);
            if (lastFolderName == "letter_missing") continue;
            int getkannadaIAST = lastFolderName.LastIndexOf('_');
            string kannadaIAST = lastFolderName[(getkannadaIAST + 1)..];

            string kannadaWord =  Aksharamukha.ConvertIASTtoKannada(kannadaIAST);

            var fileNames = PrintFileNames(samyuktaFilePath, false);

            jsonFileUpdater.UpdateJsonFileFormsArray(lettersPath, kannadaWord, fileNames, kannadaIAST);

        }
        Console.WriteLine("Samyuktaksharas updated\n");
        Console.WriteLine("===========================================================");
    }


}

string GetFilePath()
{
    Console.WriteLine("Enter the full public assets folder path (where the source code is cloned):");
    string userEntry = Console.ReadLine();

    if (!Directory.Exists(userEntry))
    {
        Console.WriteLine("The folder path you entered does not exist or is invalid.");
    }
    return userEntry;
}

void GetKannadaRootLetter(string romanIastLetter)
{

    string rootAlphabet = KannadaLetterConverter.GetRootAlphabetFromRomanIast(romanIastLetter);
    if (rootAlphabet != " ")
    {
        Console.WriteLine($"The root alphabet of {romanIastLetter} is {rootAlphabet}.");
        //Console.WriteLine($"The root alphabet of {romanIastLetter} is {rootAlphabet} ({KannadaLetterConverter.kannadaToRomanIastMap[rootAlphabet]}).");
    }
    else
    {
        Console.WriteLine("The mapping for the given Roman IAST letter was not found.");
    }
}

async Task GetShasanaDetails(bool overwriteFiles = true)
{
    string shasanasPath = JSONDirectory + "shasanas.json";
    var shasanaNames = GetAllShasanaNames(shasanasPath);
    JsonFileUpdater jsonFileUpdater = new();

    foreach (string shasanaName in shasanaNames)
    {
        if (overwriteFiles)//!File.Exists(shasanaJsonPath)
        {
            await UpdateInscriptionFile(jsonFileUpdater, shasanaName);
        }
    }
    Console.WriteLine(shasanasPath + " file updated successfully.");
    Console.WriteLine("In the shasanas.json file, For each individual inscription, update the displayName, imagePath, description and links parameters as required\n");

}

async Task UpdateInscriptionFile(JsonFileUpdater jsonFileUpdater, string shasanaName)
{
    string shasanaJsonPath = JSONDirectory + "shasanas\\" + shasanaName + ".json";

    jsonFileUpdater.ClearJsonFile(shasanaJsonPath, false);

    string[] files = Directory.GetFiles(FileDirectory, "*" + shasanaName + "*", SearchOption.AllDirectories);

    if (files.Length > 0)
    {
        await jsonFileUpdater.WriteShasanaFile(files, shasanaJsonPath, FileDirectory);
    }
    else
    {
        Console.WriteLine("No charachter images found for the inscription name\n");
    }
}

List<string> GetAllShasanaNames(string shasanasPath)
{
    Directory.SetCurrentDirectory(FileDirectory);
    List<string> names = new List<string>();
    JsonFileUpdater jsonFileUpdater = new();

    if (Directory.Exists(FileDirectory))
    {
        string[] files = Directory.GetFiles(FileDirectory, "*", SearchOption.AllDirectories);

        foreach (string fullPath in files)
        {
            string result = Path.GetFileNameWithoutExtension(fullPath);
            int indx1 = result.IndexOf('_');
            int indx2 = result.IndexOf('_', indx1 + 1);
            int indx3 = result.IndexOf('_', indx2 + 2);
            string shilasanName = result[..indx3];
            //string shilasanName = result[..indx3].Replace('_', ' ');

            names.Add(shilasanName);
        }
    }

    var uniqShasanas = names.Distinct().ToList();
    //Console.WriteLine(string.Join("\n", uniqShasanas));

    jsonFileUpdater.UpdateShasanasJson(shasanasPath, uniqShasanas);
    return uniqShasanas.ToList();
}

//check if any image names does not match the format
void VerifyImageNames()
{
    Directory.SetCurrentDirectory(FileDirectory);
    List<string> names = new List<string>();

    if (Directory.Exists(FileDirectory))
    {
        string[] filesNoMatch = Directory.GetFiles(FileDirectory, "*", SearchOption.AllDirectories)
            .Select(path => Path.GetFileName(path))
            .Where(filename => !Regex.IsMatch(filename, @"[0-9]+_[A-Za-z0-9]+_[A-Za-z0-9]+_[0-9]+_[0-9]+_[0-9]+\.[A-Za-z]+", RegexOptions.IgnoreCase))
            .ToArray();


        if (filesNoMatch.Length > 0)
        {
            Console.WriteLine("The following images do not follow the standard naming convention: 996_CP144_Malurpatna_2_12_4.JPG");

            Console.WriteLine(string.Join("\n", filesNoMatch));
        }
        else
        {
            Console.WriteLine("All image names follow the standard naming convention");
        }
    }
}

void LettersRun()
{
    //string[] letters = new string[] { "ಅ", "ಆ", "ಇ", "ಈ", "ಉ", "ಊ", "ಋ", "ಎ", "ಏ", "ಐ", "ಒ", "ಓ", "ಔ", "ಅಂ", "ಅಃ", "ಕ", "ಖ", "ಗ", "ಘ", "ಙ", "ಚ", "ಛ", "ಜ", "ಝ", "ಞ", "ಟ", "ಠ", "ಡ", "ಢ", "ಣ", "ತ", "ಥ", "ದ", "ಧ", "ನ", "ಪ", "ಫ", "ಬ", "ಭ", "ಮ", "ಯ", "ರ", "ಲ", "ವ", "ಶ", "ಷ", "ಸ", "ಹ", "ಳ" };

    //string[] IASTletters = new string[] { "a", "ā", "i", "ī", "u", "ū", "ṛ", "e", "ē", "ai", "o", "ō", "au", "aṃ", "aḥ", "ka", "kha", "ga", "gha", "ṅa", "cha", "chha", "ja", "jha", "ña", "ṭa", "ṭha", "ḍa", "ḍha", "ṇa", "ta", "tha", "da", "dha", "na", "pa", "pha", "ba", "bha", "ma", "ya", "ra", "la", "va", "śa", "ṣa", "sa", "ha", "l̤a", };
    string lettersPath = JSONDirectory + "letters.json";
    JsonFileUpdater jsonFileUpdater = new();
    jsonFileUpdater.ClearJsonFile(lettersPath);

    foreach (var item in Mapping.romanToKannada)
    {
        string path = FileDirectory + "\\" + item.Key;

        var fileNames = PrintFileNames(path, false);

        jsonFileUpdater.UpdateJsonFileFormsArray(lettersPath, item.Value.ToString(), fileNames, item.Key);

    }
    Console.WriteLine(lettersPath + " file updated");
}

void NumbersRun()
{
    string numbersJsonPath = JSONDirectory + "numbers.json";
    JsonFileUpdater jsonFileUpdater = new();
    jsonFileUpdater.ClearJsonFile(numbersJsonPath);

    foreach (var item in Mapping.kannadaNumbers)
    {
        string path = FileDirectory + "\\" + item.Key;

        var fileNames = PrintFileNames(path, false);
        jsonFileUpdater.UpdateJsonFileFormsArray(numbersJsonPath, item.Value, fileNames, item.Key);

    }
    Console.WriteLine("Numbers processing complete");
}

void ConvertForms()
{
    JsonFileUpdater fileReader = new();
    fileReader.ConvertFormsArray(JSONDirectory + "numbers.json");
}


void SamyuktaksharaReader(string filePath)
{
    JsonFileUpdater fileReader = new JsonFileUpdater();

    // Read the JSON file and get the dictionary
    Dictionary<string, string> dictionary = fileReader.ReadJsonFile(filePath);

    // Check if the dictionary is not null
    if (dictionary != null)
    {
        // Print the key-value pairs in the dictionary
        foreach (var kvp in dictionary)
        {
            //Console.WriteLine($"IASTform: {kvp.Key}, Key: {kvp.Value}");
            var fileNames = PrintFileNames(FileDirectory + "\\" + kvp.Key);

            JsonFileUpdater jsonFileUpdater = new();
            jsonFileUpdater.UpdateJsonFileFormsArray(
                JSONDirectory + "samyuktakshara\\letters.json", kvp.Value, fileNames);

        }
    }
}

void GetSymbols()
{
    string symbolsPath = FileDirectory + "\\Symbols";
    var fileNames = PrintFileNames(symbolsPath);

    JsonFileUpdater jsonFileUpdater = new();
    jsonFileUpdater.UpdateJsonFileFormsArray(
        JSONDirectory + "symbols.json", "Symbols", fileNames);
}

async Task TranslateFolderNamesToKannadaAsync()
{
    if (Directory.Exists(FileDirectory))
    {
        string[] files = Directory.GetDirectories(FileDirectory, "*", SearchOption.TopDirectoryOnly);

        var filepath = JSONDirectory + "Kannada_Characters.csv";
        using StreamWriter writer = new(new FileStream(filepath,
        FileMode.Create, FileAccess.Write));
        foreach (string fullPath in files)
        {
            string lastFolderName = Path.GetFileName(fullPath);
            string kannadaWord =  Aksharamukha.ConvertIASTtoKannada(lastFolderName);
            writer.WriteLine(lastFolderName + "," + kannadaWord);
            Console.WriteLine(lastFolderName + " , " + kannadaWord);
        }
    }
}

void SamyuktaksharaRun()
{
    Dictionary<string, Dictionary<string, string>> samyuktaDictionaries = new Dictionary<string, Dictionary<string, string>>
    {
        {"ಇ", SamyuktaMapping.imaDictionary},
  {"ಎ", SamyuktaMapping.emaDictionary},
  {"ಕ", SamyuktaMapping.kaDictionary},
  {"ಗ", SamyuktaMapping.gaDictionary},
  {"ಘ", SamyuktaMapping.ghnaDictionary},
  {"ಙ", SamyuktaMapping.nnaDictionary},
  {"ಚ", SamyuktaMapping.caDictionary},
  {"ಜ", SamyuktaMapping.jaDictionary},
  {"ಟ", SamyuktaMapping.ttaDictionary},
  {"ಡ", SamyuktaMapping.daDictionary},
  {"ಣ", SamyuktaMapping.naDictionary},
  {"ತ", SamyuktaMapping.taDictionary},
  {"ಥ", SamyuktaMapping.thaDictionary},
  {"ದ", SamyuktaMapping.ddaDictionary},
  {"ನ", SamyuktaMapping.naaDictionary},
  {"ಪ", SamyuktaMapping.paDictionary},
  {"ಬ", SamyuktaMapping.baDictionary},
  {"ಮ", SamyuktaMapping.maDictionary},
  {"ಯ", SamyuktaMapping.yaDictionary},
  {"ರ", SamyuktaMapping.raDictionary},
  {"ಲ", SamyuktaMapping.laDictionary},
  {"ವ", SamyuktaMapping.vaDictionary},
  {"ಶ", SamyuktaMapping.shaDictionary},
  {"ಷ", SamyuktaMapping.shhaaDictionary},
  {"ಸ", SamyuktaMapping.saDictionary},
  {"ಹ", SamyuktaMapping.haDictionary},
  {"ಳ", SamyuktaMapping.llaDictionary}

    };

    foreach (KeyValuePair<string, Dictionary<string, string>> consonant in samyuktaDictionaries)
    {
        AksharaUpdater(JSONDirectory + "samyuktakshara\\" + consonant.Key + ".json", consonant.Value);
        Console.WriteLine("");
        Console.WriteLine("===========================================================");

    }
}


void GunitaksharaRunLetter(string letter)
{
    var consonantDict = Mapping.consonantDictionaries[letter];

    AksharaUpdater(JSONDirectory + "gunitakshara\\" + letter + ".json", consonantDict);
    Console.WriteLine("");
    Console.WriteLine("===========================================================");
}

void GunitaksharaRun()
{
    foreach (KeyValuePair<string, Dictionary<string, string>> consonant in Mapping.consonantDictionaries)
    {
        AksharaUpdater(JSONDirectory + "gunitakshara\\" + consonant.Key + ".json", consonant.Value);
        Console.WriteLine("");
        Console.WriteLine("===========================================================");

    }
}

void PathUpdater()
{
    while (true)
    {
        Console.WriteLine("Enter file path: ");

        string path = Console.ReadLine();
        string lastFolderName = Path.GetFileName(path);
        //string lastFolderName = Path.GetFileName(Path.GetDirectoryName(path));

        if (path.Equals("exit", StringComparison.OrdinalIgnoreCase))
        {
            break;
        }
        var fileNames = PrintFileNames(path);

        JsonFileUpdater jsonFileUpdater = new();
        jsonFileUpdater.UpdateJsonFileFormsArray(
            JSONDirectory + "gunitakshara\\ಕ.json", lastFolderName, fileNames);
    }
}

void AksharaUpdater(string jsonPath, Dictionary<string, string> mapDictionary)
{
    JsonFileUpdater jsonFileUpdater = new();
    jsonFileUpdater.ClearJsonFile(jsonPath);

    foreach (KeyValuePair<string, string> entry in mapDictionary)
    {
        string path = FileDirectory + "\\" + entry.Key;
        var fileNames = PrintFileNames(path, false);
        jsonFileUpdater.UpdateJsonFileFormsArray(jsonPath, entry.Value, fileNames, entry.Key, printFinalOutput: false);
    }
    Console.WriteLine(jsonPath + " file updated");

}

List<string> PrintFileNames(string path, bool printFoundFiles = true)
{
    Directory.SetCurrentDirectory(FileDirectory);
    List<string> names = new List<string>();


    if (Directory.Exists(path))
    {
        string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

        foreach (string fullPath in files)
        {
            string result = Path.GetRelativePath(FileDirectory, fullPath);

            result = result.Replace("\\", "/");

            names.Add(result);
        }

        if (printFoundFiles)
        {
            Console.WriteLine(string.Join(",", names));
        }

    }
    else
    {
        Console.WriteLine(path + " :does not exist");
    }
    return names;
}