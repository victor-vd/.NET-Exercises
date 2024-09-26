using ClientLogin.Components;

//16, "cleber glauco", "11/01/2000"
Client cleber = new Client();
Client felipe = new Client();

string[]? lines = null;

try
{
    lines = File.ReadAllLines("ClienLogin/Assets/cleber.txt");
}
catch (FileNotFoundException)
{
    Console.WriteLine("file not found");
}
catch (DirectoryNotFoundException)
{
    Console.WriteLine("directory not found");
}
finally
{
    Console.WriteLine("The file was found sucessfully");
}

cleber.Name = lines[0];
cleber.Birthday = lines[1];
cleber.Email = lines[2];
cleber.Password = lines[3];

cleber.Check();

/* cleber.Name = "cleber glauco";
cleber.Birthday = "2005/08/19";

cleber.Check(); */


felipe.Name = "felipe rocha";
felipe.Birthday = "1978/11/13";
felipe.Email = "felipe1123123111@gmail.com";
felipe.Password = "AYV&GHF*)Evb7¨*(&R)";

felipe.Check();

/* felipe.Name = "felipe glauco";
felipe.Birthday = "2002/04/14";

felipe.Check(); */

