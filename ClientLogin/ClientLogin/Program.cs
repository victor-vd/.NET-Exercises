using ClientLogin.Components;

//Queue<Client> queue = new Queue<Client>();
List<string[]> clientFiles = new List<string[]>();

Client cleber = new Client("Cleber Rocha");
Client felipe = new Client("Felipe Rocha");
Client john = new Client("John Mark");

clientFiles.Add(cleber.getClientFile());
clientFiles.Add(felipe.getClientFile());
clientFiles.Add(john.getClientFile());

cleber.Birthday = clientFiles[0][0];
cleber.Email = clientFiles[0][1];
cleber.Password = clientFiles[0][2];
cleber.Country = clientFiles[0][3];
Console.WriteLine(cleber);

felipe.Birthday = clientFiles[1][0];
felipe.Email = clientFiles[1][1];
felipe.Password = clientFiles[1][2];
felipe.Country = clientFiles[1][3];
Console.WriteLine(felipe);

john.Birthday = clientFiles[2][0];
john.Email = clientFiles[2][1];
john.Password = clientFiles[2][2];
john.Country = clientFiles[2][3];
Console.WriteLine(john);
