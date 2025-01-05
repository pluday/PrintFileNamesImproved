using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFileNames.Mappings
{
    public static class Mapping
    {
        public static Dictionary<string, string> romanToKannada = new Dictionary<string, string>()
        {
            {"a", "ಅ"},
            {"ā", "ಆ"},
            {"i", "ಇ"},
            {"ī", "ಈ"},
            {"u", "ಉ"},
            {"ū", "ಊ"},
            {"ṛ", "ಋ"},
            {"ĕ", "ಎ"},
            {"e", "ಏ"},
            {"ai", "ಐ"},
            {"ŏ", "ಒ"},
            {"o", "ಓ"},
            {"au", "ಔ"},
            {"aṃ", "ಅಂ" },
            {"aḥ","ಅಃ" },
            {"ka", "ಕ"},
            {"kha", "ಖ"},
            {"ga", "ಗ"},
            {"gha", "ಘ"},
            {"ṅa", "ಙ"},
            {"ca", "ಚ"},
            {"cha", "ಛ"},
            {"ja", "ಜ"},
            {"jha", "ಝ"},
            {"ña", "ಞ"},
            {"ṭa", "ಟ"},
            {"ṭha", "ಠ"},
            {"ḍa", "ಡ"},
            {"ḍha", "ಢ"},
            {"ṇa", "ಣ"},
            {"ta", "ತ"},
            {"tha", "ಥ"},
            {"da", "ದ"},
            {"dha", "ಧ"},
            {"na", "ನ"},
            {"pa", "ಪ"},
            {"pha", "ಫ"},
            {"ba", "ಬ"},
            {"bha", "ಭ"},
            {"ma", "ಮ"},
            {"ya", "ಯ"},
            {"ra", "ರ"},
            {"la", "ಲ"},
            {"va", "ವ"},
            {"śa", "ಶ"},
            {"ṣa", "ಷ"},
            {"sa", "ಸ"},
            {"ha", "ಹ"},
            {"l̤a", "ಳ"},
            {"ṟa", "ಱ"}
        };

        public static Dictionary<string, string> kannadaNumbers = new Dictionary<string, string>()
{
    { "0", "೦" },
    { "1", "೧" },
    { "2", "೨" },
    { "3", "೩" },
    { "4", "೪" },
    { "5", "೫" },
    { "6", "೬" },
    { "7", "೭" },
    { "8", "೮" },
    { "9", "೯" }
};

        // Dictionaries for each consonant
        public static Dictionary<string, string> kaDictionary = new Dictionary<string, string>
        {
            {"ka", "ಕ"},
            {"kā", "ಕಾ"},
            {"ki", "ಕಿ"},
            {"kī", "ಕೀ"},
            {"ku", "ಕು"},
            {"kū", "ಕೂ"},
            {"kṛ", "ಕೃ"},
            {"ke", "ಕೆ"},
            {"kē", "ಕೇ"},
            {"kai", "ಕೈ"},
            {"ko", "ಕೊ"},
            {"kō", "ಕೋ"},
            {"kau", "ಕೌ"},
            {"kaṃ", "ಕಂ"},
            {"kaḥ", "ಕಃ"},
        };

        public static Dictionary<string, string> khaDictionary = new Dictionary<string, string>
        {
            {"kha", "ಖ"},
            {"khā", "ಖಾ"},
            {"khi", "ಖಿ"},
            {"khī", "ಖೀ"},
            {"khu", "ಖು"},
            {"khū", "ಖೂ"},
            {"khṛ", "ಖೃ"},
            {"khe", "ಖೆ"},
            {"khē", "ಖೇ"},
            {"khai", "ಖೈ"},
            {"kho", "ಖೊ"},
            {"khō", "ಖೋ"},
            {"khau", "ಖೌ"},
            {"khaṃ", "ಖಂ"},
            {"khaḥ", "ಖಃ"},
        };

        public static Dictionary<string, string> gaDictionary = new Dictionary<string, string>
        {
            {"ga", "ಗ"},
            {"gā", "ಗಾ"},
            {"gi", "ಗಿ"},
            {"gī", "ಗೀ"},
            {"gu", "ಗು"},
            {"gū", "ಗೂ"},
            {"gṛ", "ಗೃ"},
            {"ge", "ಗೆ"},
            {"gē", "ಗೇ"},
            {"gai", "ಗೈ"},
            {"go", "ಗೊ"},
            {"gō", "ಗೋ"},
            {"gau", "ಗೌ"},
            {"gaṃ", "ಗಂ"},
            {"gaḥ", "ಗಃ"},
        };

        public static Dictionary<string, string> ghaDictionary = new Dictionary<string, string>
        {
            {"gha", "ಘ"},
            {"ghā", "ಘಾ"},
            {"ghi", "ಘಿ"},
            {"ghī", "ಘೀ"},
            {"ghu", "ಘು"},
            {"ghū", "ಘೂ"},
            {"ghṛ", "ಘೃ"},
            {"ghe", "ಘೆ"},
            {"ghē", "ಘೇ"},
            {"ghai", "ಘೈ"},
            {"gho", "ಘೊ"},
            {"ghō", "ಘೋ"},
            {"ghau", "ಘೌ"},
            {"ghaṃ", "ಘಂ"},
            {"ghaḥ", "ಘಃ"},
        };

        public static Dictionary<string, string> ngaDictionary = new Dictionary<string, string>
        {
            {"ṅa", "ಙ"},
            {"ṅā", "ಙಾ"},
            {"ṅi", "ಙಿ"},
            {"ṅī", "ಙೀ"},
            {"ṅu", "ಙು"},
            {"ṅū", "ಙೂ"},
            {"ṅṛ", "ಙೃ"},
            {"ṅe", "ಙೆ"},
            {"ṅē", "ಙೇ"},
            {"ṅai", "ಙೈ"},
            {"ṅo", "ಙೊ"},
            {"ṅō", "ಙೋ"},
            {"ṅau", "ಙೌ"},
            {"ṅaṃ", "ಙಂ"},
            {"ṅaḥ", "ಙಃ"},
        };

        public static Dictionary<string, string> caDictionary = new Dictionary<string, string>
        {
            {"ca", "ಚ"},
            {"cā", "ಚಾ"},
            {"ci", "ಚಿ"},
            {"cī", "ಚೀ"},
            {"cu", "ಚು"},
            {"cū", "ಚೂ"},
            {"cṛ", "ಚೃ"},
            {"ce", "ಚೆ"},
            {"cē", "ಚೇ"},
            {"cai", "ಚೈ"},
            {"co", "ಚೊ"},
            {"cō", "ಚೋ"},
            {"cau", "ಚೌ"},
            {"caṃ", "ಚಂ"},
            {"caḥ", "ಚಃ"},
        };

        public static Dictionary<string, string> chaDictionary = new Dictionary<string, string>
        {
            {"cha", "ಛ"},
            {"chā", "ಛಾ"},
            {"chi", "ಛಿ"},
            {"chī", "ಛೀ"},
            {"chu", "ಛು"},
            {"chū", "ಛೂ"},
            {"chṛ", "ಛೃ"},
            {"che", "ಛೆ"},
            {"chē", "ಛೇ"},
            {"chai", "ಛೈ"},
            {"cho", "ಛೊ"},
            {"chō", "ಛೋ"},
            {"chau", "ಛೌ"},
            {"chaṃ", "ಛಂ"},
            {"chaḥ", "ಛಃ"},
        };

        public static Dictionary<string, string> jaDictionary = new Dictionary<string, string>
        {
            {"ja", "ಜ"},
            {"jā", "ಜಾ"},
            {"ji", "ಜಿ"},
            {"jī", "ಜೀ"},
            {"ju", "ಜು"},
            {"jū", "ಜೂ"},
            {"jṛ", "ಜೃ"},
            {"je", "ಜೆ"},
            {"jē", "ಜೇ"},
            {"jai", "ಜೈ"},
            {"jo", "ಜೊ"},
            {"jō", "ಜೋ"},
            {"jau", "ಜೌ"},
            {"jaṃ", "ಜಂ"},
            {"jaḥ", "ಜಃ"},
        };

        public static Dictionary<string, string> jhaDictionary = new Dictionary<string, string>
        {
            {"jha", "ಝ"},
            {"jhā", "ಝಾ"},
            {"jhi", "ಝಿ"},
            {"jhī", "ಝೀ"},
            {"jhu", "ಝು"},
            {"jhū", "ಝೂ"},
            {"jhṛ", "ಝೃ"},
            {"jhe", "ಝೆ"},
            {"jhē", "ಝೇ"},
            {"jhai", "ಝೈ"},
            {"jho", "ಝೊ"},
            {"jhō", "ಝೋ"},
            {"jhau", "ಝೌ"},
            {"jhaṃ", "ಝಂ"},
            {"jhaḥ", "ಝಃ"},
        };

        public static Dictionary<string, string> nyaDictionary = new Dictionary<string, string>
        {
            {"ña", "ಞ"},
            {"ñā", "ಞಾ"},
            {"ñi", "ಞಿ"},
            {"ñī", "ಞೀ"},
            {"ñu", "ಞು"},
            {"ñū", "ಞೂ"},
            {"ñe", "ಞೆ"},
            {"ñē", "ಞೇ"},
            {"ño", "ಞೊ"},
            {"ñō", "ಞೋ"},
            {"ñai", "ಞೈ"},
            {"ñau", "ಞೌ"},
            {"ñṛ", "ಞೃ"},
            {"ñaṃ", "ಞಂ"},
            {"ñaḥ", "ಞಃ"},
        };

        public static Dictionary<string, string> ṭaDictionary = new Dictionary<string, string>
        {
            {"ṭa", "ಟ"},
            {"ṭā", "ಟಾ"},
            {"ṭi", "ಟಿ"},
            {"ṭī", "ಟೀ"},
            {"ṭu", "ಟು"},
            {"ṭū", "ಟೂ"},
            {"ṭṛ", "ಟೃ"},
            {"ṭe", "ಟೆ"},
            {"ṭē", "ಟೇ"},
            {"ṭai", "ಟೈ"},
            {"ṭo", "ಟೊ"},
            {"ṭō", "ಟೋ"},
            {"ṭau", "ಟೌ"},
            {"ṭaṃ", "ಟಂ"},
            {"ṭaḥ", "ಟಃ"},
        };

        public static Dictionary<string, string> ṭhaDictionary = new Dictionary<string, string>
        {
            {"ṭha", "ಠ"},
            {"ṭhā", "ಠಾ"},
            {"ṭhi", "ಠಿ"},
            {"ṭhī", "ಠೀ"},
            {"ṭhu", "ಠು"},
            {"ṭhū", "ಠೂ"},
            {"ṭhṛ", "ಠೃ"},
            {"ṭhe", "ಠೆ"},
            {"ṭhē", "ಠೇ"},
            {"ṭhai", "ಠೈ"},
            {"ṭho", "ಠೊ"},
            {"ṭhō", "ಠೋ"},
            {"ṭhau", "ಠೌ"},
            {"ṭhaṃ", "ಠಂ"},
            {"ṭhaḥ", "ಠಃ"},
        };

        public static Dictionary<string, string> ddaDictionary = new Dictionary<string, string>
        {
            {"da", "ಡ"},
            {"dā", "ಡಾ"},
            {"di", "ಡಿ"},
            {"dī", "ಡೀ"},
            {"du", "ಡು"},
            {"dū", "ಡೂ"},
            {"dṛ", "ಡೃ"},
            {"de", "ಡೆ"},
            {"dē", "ಡೇ"},
            {"dai", "ಡೈ"},
            {"do", "ಡೊ"},
            {"dō", "ಡೋ"},
            {"dau", "ಡೌ"},
            {"daṃ", "ಡಂ"},
            {"daḥ", "ಡಃ"},
        };

        public static Dictionary<string, string> ḍaDictionary = new Dictionary<string, string>
        {
            {"ḍa", "ಢ"},
            {"ḍā", "ಢಾ"},
            {"ḍi", "ಢಿ"},
            {"ḍī", "ಢೀ"},
            {"ḍu", "ಢು"},
            {"ḍū", "ಢೂ"},
            {"ḍṛ", "ಢೃ"},
            {"ḍe", "ಢೆ"},
            {"ḍē", "ಢೇ"},
            {"ḍai", "ಢೈ"},
            {"ḍo", "ಢೊ"},
            {"ḍō", "ಢೋ"},
            {"ḍau", "ಢೌ"},
            {"ḍaṃ", "ಢಂ"},
            {"ḍaḥ", "ಢಃ"},
        };

        public static Dictionary<string, string> ṇaDictionary = new Dictionary<string, string>
        {
            {"ṇa", "ಣ"},
            {"ṇā", "ಣಾ"},
            {"ṇi", "ಣಿ"},
            {"ṇī", "ಣೀ"},
            {"ṇu", "ಣು"},
            {"ṇū", "ಣೂ"},
            {"ṇṛ", "ಣೃ"},
            {"ṇe", "ಣೆ"},
            {"ṇē", "ಣೇ"},
            {"ṇai", "ಣೈ"},
            {"ṇo", "ಣೊ"},
            {"ṇō", "ಣೋ"},
            {"ṇau", "ಣೌ"},
            {"ṇaṃ", "ಣಂ"},
            {"ṇaḥ", "ಣಃ"},
        };

        public static Dictionary<string, string> taDictionary = new Dictionary<string, string>
        {
            {"ta", "ತ"},
            {"tā", "ತಾ"},
            {"ti", "ತಿ"},
            {"tī", "ತೀ"},
            {"tu", "ತು"},
            {"tū", "ತೂ"},
            {"tṛ", "ತೃ"},
            {"te", "ತೆ"},
            {"tē", "ತೇ"},
            {"tai", "ತೈ"},
            {"to", "ತೊ"},
            {"tō", "ತೋ"},
            {"tau", "ತೌ"},
            {"taṃ", "ತಂ"},
            {"taḥ", "ತಃ"},
        };

        public static Dictionary<string, string> thaDictionary = new Dictionary<string, string>
        {
            {"tha", "ಥ"},
            {"thā", "ಥಾ"},
            {"thi", "ಥಿ"},
            {"thī", "ಥೀ"},
            {"thu", "ಥು"},
            {"thū", "ಥೂ"},
            {"thṛ", "ಥೃ"},
            {"the", "ಥೆ"},
            {"thē", "ಥೇ"},
            {"thai", "ಥೈ"},
            {"tho", "ಥೊ"},
            {"thō", "ಥೋ"},
            {"thau", "ಥೌ"},
            {"thaṃ", "ಥಂ"},
            {"thaḥ", "ಥಃ"},
        };

        public static Dictionary<string, string> daDictionary = new Dictionary<string, string>
        {
            {"da", "ದ"},
            {"dā", "ದಾ"},
            {"di", "ದಿ"},
            {"dī", "ದೀ"},
            {"du", "ದು"},
            {"dū", "ದೂ"},
            {"dṛ", "ದೃ"},
            {"de", "ದೆ"},
            {"dē", "ದೇ"},
            {"dai", "ದೈ"},
            {"do", "ದೊ"},
            {"dō", "ದೋ"},
            {"dau", "ದೌ"},
            {"daṃ", "ದಂ"},
            {"daḥ", "ದಃ"},
        };

        public static Dictionary<string, string> dhaDictionary = new Dictionary<string, string>
        {
            {"dha", "ಧ"},
            {"dhā", "ಧಾ"},
            {"dhi", "ಧಿ"},
            {"dhī", "ಧೀ"},
            {"dhu", "ಧು"},
            {"dhū", "ಧೂ"},
            {"dhṛ", "ಧೃ"},
            {"dhe", "ಧೆ"},
            {"dhē", "ಧೇ"},
            {"dhai", "ಧೈ"},
            {"dho", "ಧೊ"},
            {"dhō", "ಧೋ"},
            {"dhau", "ಧೌ"},
            {"dhaṃ", "ಧಂ"},
            {"dhaḥ", "ಧಃ"},
        };

        public static Dictionary<string, string> naDictionary = new Dictionary<string, string>
        {
            {"na", "ನ"},
            {"nā", "ನಾ"},
            {"ni", "ನಿ"},
            {"nī", "ನೀ"},
            {"nu", "ನು"},
            {"nū", "ನೂ"},
            {"nṛ", "ನೃ"},
            {"ne", "ನೆ"},
            {"nē", "ನೇ"},
            {"nai", "ನೈ"},
            {"no", "ನೊ"},
            {"nō", "ನೋ"},
            {"nau", "ನೌ"},
            {"naṃ", "ನಂ"},
            {"naḥ", "ನಃ"},
        };

        public static Dictionary<string, string> paDictionary = new Dictionary<string, string>
        {
            {"pa", "ಪ"},
            {"pā", "ಪಾ"},
            {"pi", "ಪಿ"},
            {"pī", "ಪೀ"},
            {"pu", "ಪು"},
            {"pū", "ಪೂ"},
            {"pṛ", "ಪೃ"},
            {"pe", "ಪೆ"},
            {"pē", "ಪೇ"},
            {"pai", "ಪೈ"},
            {"po", "ಪೊ"},
            {"pō", "ಪೋ"},
            {"pau", "ಪೌ"},
            {"paṃ", "ಪಂ"},
            {"paḥ", "ಪಃ"},
        };

        public static Dictionary<string, string> phaDictionary = new Dictionary<string, string>
        {
            {"pha", "ಫ"},
            {"phā", "ಫಾ"},
            {"phi", "ಫಿ"},
            {"phī", "ಫೀ"},
            {"phu", "ಫು"},
            {"phū", "ಫೂ"},
            {"phṛ", "ಫೃ"},
            {"phe", "ಫೆ"},
            {"phē", "ಫೇ"},
            {"phai", "ಫೈ"},
            {"pho", "ಫೊ"},
            {"phō", "ಫೋ"},
            {"phau", "ಫೌ"},
            {"phaṃ", "ಫಂ"},
            {"phaḥ", "ಫಃ"},
        };

        public static Dictionary<string, string> baDictionary = new Dictionary<string, string>
        {
            {"ba", "ಬ"},
            {"bā", "ಬಾ"},
            {"bi", "ಬಿ"},
            {"bī", "ಬೀ"},
            {"bu", "ಬು"},
            {"bū", "ಬೂ"},
            {"bṛ", "ಬೃ"},
            {"be", "ಬೆ"},
            {"bē", "ಬೇ"},
            {"bai", "ಬೈ"},
            {"bo", "ಬೊ"},
            {"bō", "ಬೋ"},
            {"bau", "ಬೌ"},
            {"baṃ", "ಬಂ"},
            {"baḥ", "ಬಃ"},
        };

        public static Dictionary<string, string> bhaDictionary = new Dictionary<string, string>
        {
            {"bha", "ಭ"},
            {"bhā", "ಭಾ"},
            {"bhi", "ಭಿ"},
            {"bhī", "ಭೀ"},
            {"bhu", "ಭು"},
            {"bhū", "ಭೂ"},
            {"bhṛ", "ಭೃ"},
            {"bhe", "ಭೆ"},
            {"bhē", "ಭೇ"},
            {"bhai", "ಭೈ"},
            {"bho", "ಭೊ"},
            {"bhō", "ಭೋ"},
            {"bhau", "ಭೌ"},
            {"bhaṃ", "ಭಂ"},
            {"bhaḥ", "ಭಃ"},
        };

        public static Dictionary<string, string> maDictionary = new Dictionary<string, string>
        {
            {"ma", "ಮ"},
            {"mā", "ಮಾ"},
            {"mi", "ಮಿ"},
            {"mī", "ಮೀ"},
            {"mu", "ಮು"},
            {"mū", "ಮೂ"},
            {"mṛ", "ಮೃ"},
            {"me", "ಮೆ"},
            {"mē", "ಮೇ"},
            {"mai", "ಮೈ"},
            {"mo", "ಮೊ"},
            {"mō", "ಮೋ"},
            {"mau", "ಮೌ"},
            {"maṃ", "ಮಂ"},
            {"maḥ", "ಮಃ"},
        };

        public static Dictionary<string, string> yaDictionary = new Dictionary<string, string>
        {
            {"ya", "ಯ"},
            {"yā", "ಯಾ"},
            {"yi", "ಯಿ"},
            {"yī", "ಯೀ"},
            {"yu", "ಯು"},
            {"yū", "ಯೂ"},
            {"yṛ", "ಯೃ"},
            {"ye", "ಯೆ"},
            {"yē", "ಯೇ"},
            {"yai", "ಯೈ"},
            {"yo", "ಯೊ"},
            {"yō", "ಯೋ"},
            {"yau", "ಯೌ"},
            {"yaṃ", "ಯಂ"},
            {"yaḥ", "ಯಃ"},
        };

        public static Dictionary<string, string> raDictionary = new Dictionary<string, string>
        {
            {"ra", "ರ"},
            {"rā", "ರಾ"},
            {"ri", "ರಿ"},
            {"rī", "ರೀ"},
            {"ru", "ರು"},
            {"rū", "ರೂ"},
            {"rṛ", "ರೃ"},
            {"re", "ರೆ"},
            {"rē", "ರೇ"},
            {"rai", "ರೈ"},
            {"ro", "ರೊ"},
            {"rō", "ರೋ"},
            {"rau", "ರೌ"},
            {"raṃ", "ರಂ"},

            {"raḥ", "ರಃ"},
        };

        public static Dictionary<string, string> laDictionary = new Dictionary<string, string>
        {
            {"la", "ಲ"},
            {"lā", "ಲಾ"},
            {"li", "ಲಿ"},
            {"lī", "ಲೀ"},
            {"lu", "ಲು"},
            {"lū", "ಲೂ"},
            {"lṛ", "ಲೃ"},
            {"le", "ಲೆ"},
            {"lē", "ಲೇ"},
            {"lai", "ಲೈ"},
            {"lo", "ಲೊ"},
            {"lō", "ಲೋ"},
            {"lau", "ಲೌ"},
            {"laṃ", "ಲಂ"},
            {"laḥ", "ಲಃ"},
        };

        public static Dictionary<string, string> vaDictionary = new Dictionary<string, string>
        {
            {"va", "ವ"},
            {"vā", "ವಾ"},
            {"vi", "ವಿ"},
            {"vī", "ವೀ"},
            {"vu", "ವು"},
            {"vū", "ವೂ"},
            {"vṛ", "ವೃ"},
            {"ve", "ವೆ"},
            {"vē", "ವೇ"},
            {"vai", "ವೈ"},
            {"vo", "ವೊ"},
            {"vō", "ವೋ"},
            {"vau", "ವೌ"},
            {"vaṃ", "ವಂ"},
            {"vaḥ", "ವಃ"},
        };

        public static Dictionary<string, string> shaDictionary = new Dictionary<string, string>
        {
            {"śa", "ಶ"},
            {"śā", "ಶಾ"},
            {"śi", "ಶಿ"},
            {"śī", "ಶೀ"},
            {"śu", "ಶು"},
            {"śū", "ಶೂ"},
            {"śṛ", "ಶೃ"},
            {"śĕ", "ಶೆ"},
            {"śe", "ಶೇ"},
            {"śai", "ಶೈ"},
            {"śŏ", "ಶೊ"},
            {"śo", "ಶೋ"},
            {"śau", "ಶೌ"},
            {"śaṃ", "ಶಂ"},
            {"śaḥ", "ಶಃ"},
        };

        public static Dictionary<string, string> ṣhaDictionary = new Dictionary<string, string>
        {
            {"ṣa", "ಷ"},
            {"ṣā", "ಷಾ"},
            {"ṣi", "ಷಿ"},
            {"ṣī", "ಷೀ"},
            {"ṣu", "ಷು"},
            {"ṣū", "ಷೂ"},
            {"ṣṛ", "ಷೃ"},
            {"ṣĕ", "ಷೆ"},
            {"ṣe", "ಷೇ"},
            {"ṣai", "ಷೈ"},
            {"ṣŏ", "ಷೊ"},
            {"ṣo", "ಷೋ"},
            {"ṣau", "ಷೌ"},
            {"ṣaṃ", "ಷಂ"},
            {"ṣaḥ", "ಷಃ"},
        };

        public static Dictionary<string, string> saDictionary = new Dictionary<string, string>
        {
            {"sa", "ಸ"},
            {"sā", "ಸಾ"},
            {"si", "ಸಿ"},
            {"sī", "ಸೀ"},
            {"su", "ಸು"},
            {"sū", "ಸೂ"},
            {"sṛ", "ಸೃ"},
            {"se", "ಸೆ"},
            {"sē", "ಸೇ"},
            {"sai", "ಸೈ"},
            {"so", "ಸೊ"},
            {"sō", "ಸೋ"},
            {"sau", "ಸೌ"},
            {"saḥ", "ಸಃ"},
            {"saṃ", "ಸಂ"},
        };

        public static Dictionary<string, string> haDictionary = new Dictionary<string, string>
        {
            {"ha", "ಹ"},
            {"hā", "ಹಾ"},
            {"hi", "ಹಿ"},
            {"hī", "ಹೀ"},
            {"hu", "ಹು"},
            {"hū", "ಹೂ"},
            {"hṛ", "ಹೃ"},
            {"he", "ಹೆ"},
            {"hē", "ಹೇ"},
            {"hai", "ಹೈ"},
            {"ho", "ಹೊ"},
            {"hō", "ಹೋ"},
            {"hau", "ಹೌ"},
            {"haṃ", "ಹಂ"},
            {"haḥ", "ಹಃ"}
        };

        public static Dictionary<string, string> llaDictionary = new Dictionary<string, string>
        {
            {"l̤a", "ಳ"},
            {"l̤ā", "ಳಾ"},
            {"l̤i", "ಳಿ"},
            {"l̤ī", "ಳೀ"},
            {"l̤u", "ಳು"},
            {"l̤ū", "ಳೂ"},
            {"l̤ṛ", "ಳೃ"},
            {"l̤ĕ", "ಳೆ"},
            {"l̤e", "ಳೇ"},
            {"l̤ai", "ಳೈ"},
            {"l̤ŏ", "ಳೊ"},
            {"l̤o", "ಳೋ"},
            {"l̤au", "ಳೌ"},
            {"l̤aṃ", "ಳಂ"},
            {"l̤aḥ", "ಳಃ"}
        };

        public static Dictionary<string, string> lllaDictionary = new Dictionary<string, string>
{
    {"ṟa", "ಱ"},
    {"ṟā", "ಱಾ"},
    {"ṟi", "ಱಿ"},
    {"ṟī", "ಱೀ"},
    {"ṟu", "ಱು"},
    {"ṟū", "ಱೂ"},
    {"ṟe", "ಱೆ"},
    {"ṟē", "ಱೇ"},
    {"ṟo", "ಱೊ"},
    {"ṟō", "ಱೋ"},
    {"ṟai", "ಱೈ"},
    {"ṟau", "ಱೌ"},
    {"ṟṛ", "ಱೃ"},
    {"ṟaḥ", "ಱಃ"},
    {"ṟaṃ", "ಱಂ"}
};


        public static Dictionary<string, Dictionary<string, string>> consonantDictionaries = new Dictionary<string, Dictionary<string, string>>
        {
            {"ಕ", Mapping.kaDictionary},
            {"ಖ", Mapping.khaDictionary},
            {"ಗ", Mapping.gaDictionary},
            {"ಘ", Mapping.ghaDictionary},
            {"ಙ", Mapping.ngaDictionary},
            {"ಚ", Mapping.caDictionary},
            {"ಛ", Mapping.chaDictionary},
            {"ಜ", Mapping.jaDictionary},
            {"ಝ", Mapping.jhaDictionary},
            {"ಞ", Mapping.nyaDictionary},
            {"ಟ", Mapping.ṭaDictionary},
            {"ಠ", Mapping.ṭhaDictionary},
            {"ಡ", Mapping.ddaDictionary},
            {"ಢ", Mapping.ḍaDictionary},
            {"ಣ", Mapping.ṇaDictionary},
            {"ತ", Mapping.taDictionary},
            {"ಥ", Mapping.thaDictionary},
            {"ದ", Mapping.daDictionary},
            {"ಧ", Mapping.dhaDictionary},
            {"ನ", Mapping.naDictionary},
            {"ಪ", Mapping.paDictionary},
            {"ಫ", Mapping.phaDictionary},
            {"ಬ", Mapping.baDictionary},
            {"ಭ", Mapping.bhaDictionary},
            {"ಮ", Mapping.maDictionary},
            {"ಯ", Mapping.yaDictionary},
            {"ರ", Mapping.raDictionary},
            {"ಲ", Mapping.laDictionary},
            {"ವ", Mapping.vaDictionary},
            {"ಶ", Mapping.shaDictionary},
            {"ಷ", Mapping.ṣhaDictionary},
            {"ಸ", Mapping.saDictionary},
            {"ಹ", Mapping.haDictionary},
            {"ಳ", Mapping.llaDictionary},
            {"ಱ", Mapping.lllaDictionary}

        };
    }
}
