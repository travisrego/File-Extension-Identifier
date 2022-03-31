// This program supports the following extensions in the input file:

Console.WriteLine("Type the file name with extension");
var input = Console.ReadLine(); // Reads the file name with extension   
if (input != null)
{
    var fileInfo = new FileInfo(input);  // Create a FileInfo object


// switch case to check the file type 
    switch (fileInfo.Extension)
    {
        case ".txt":
            Console.WriteLine("Text file");
            break;
        case ".doc":
            Console.WriteLine("Word file");
            break;
        case ".pdf":
            Console.WriteLine("PDF file");
            break;
        case ".jpg":
            Console.WriteLine("JPG file");
            break;
        case ".png":
            Console.WriteLine("PNG file");
            break;
        case ".gif":
            Console.WriteLine("GIF file");
            break;
        case ".mp3":
            Console.WriteLine("MP3 file");
            break;
        case ".mp4":
            Console.WriteLine("MP4 file");
            break;
        case ".avi":
            Console.WriteLine("AVI file");
            break;
        case ".mov":
            Console.WriteLine("MOV file");
            break;
        case ".wmv":
            Console.WriteLine("WMV file");
            break;
        case ".mpg":
            Console.WriteLine("MPG file");
            break;
        case ".mpeg":
            Console.WriteLine("MPEG file");
            break;
        case ".zip":
            Console.WriteLine("ZIP file");
            break;
        case ".rar":
            Console.WriteLine("RAR file");
            break;
        case ".7z":
            Console.WriteLine("7Z file");
            break;
        case ".iso":
            Console.WriteLine("ISO file");
            break;
        case ".exe":
            Console.WriteLine("EXE file");
            break;
        case ".dll":
            Console.WriteLine("DLL file");
            break;
        case ".msi":
            Console.WriteLine("MSI file");
            break;
        case ".docx":
            Console.WriteLine("DOCX file");
            break;
        case ".xlsx":
            Console.WriteLine("XLSX file");
            break;
        case ".pptx":
            Console.WriteLine("PPTX file");
            break;
        case ".csv":
            Console.WriteLine("CSV file");
            break;
        case ".xml":
            Console.WriteLine("XML file");
            break;
        case ".html":
            Console.WriteLine("HTML file");
            break;
        case ".css":
            Console.WriteLine("CSS file");
            break;
        case ".js":
            Console.WriteLine("JS file");
            break;
        case ".json":
            Console.WriteLine("JSON file");
            break;
        case ".sql":
            Console.WriteLine("SQL file");
            break;
        case ".md":
            Console.WriteLine("MD file");
            break;
        case ".php":
            Console.WriteLine("PHP file");
            break;
        case ".asp":
            Console.WriteLine("ASP file");
            break;
        case ".aspx":
            Console.WriteLine("ASPX file");
            break;
        case ".jsp":
            Console.WriteLine("JSP file");
            break;
        case ".cfm":
            Console.WriteLine("CFM file");
            break;
        case ".pl":
            Console.WriteLine("PL file");
            break;
        case ".py":
            Console.WriteLine("PY file");
            break;
        case ".rb":
            Console.WriteLine("RB file");
            break;
        case ".sh":
            Console.WriteLine("SH file");
            break;
        case ".swf":
            Console.WriteLine("SWF file");
            break;
        case ".fla":
            Console.WriteLine("FLA file");
            break;
        case ".flv":
            Console.WriteLine("FLV file");
            break;
        case ".f4v":
            Console.WriteLine("F4V file");
            break;
        case ".m4v":
            Console.WriteLine("M4V file");
            break;      
        case ".3gp":
            Console.WriteLine("3GP file");
            break;
        case ".3g2":
            Console.WriteLine("3G2 file");
            break;
        case ".m2ts":
            Console.WriteLine("M2TS file");
            break;
        case ".mts":
            Console.WriteLine("MTS file");
            break;
        case ".ts":
            Console.WriteLine("TS file");
            break;
        case ".wma":
            Console.WriteLine("WMA file");
            break;
        case ".aac":
            Console.WriteLine("AAC file");
            break;
        case ".m4a":
            Console.WriteLine("M4A file");
            break;
        case ".obj":
            Console.WriteLine("OBJ file");
            break;
        case ".mtl":
            Console.WriteLine("MTL file");
            break;
        case ".fbx":
            Console.WriteLine("FBX file");
            break;
        case ".gltf":
            Console.WriteLine("GLTF file");
            break;
        case ".glb":
            Console.WriteLine("GLB file");
            break;
        case ".dae":
            Console.WriteLine("DAE file");
            break;
        case ".kdbx":
            Console.WriteLine("KDBX file");
            break;  
        case ".kdb":
            Console.WriteLine("KDB file");
            break;
        case ".bmp":
            Console.WriteLine("BMP file");
            break;
        case " ":
            Console.WriteLine("No file");
            break; 
        default:
            Console.WriteLine("Unknown file type");
            break;
    }
}
else { Console.WriteLine("No file"); }