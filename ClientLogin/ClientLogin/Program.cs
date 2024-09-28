using ClientLogin.Components;

//Queue<Client> queue = new Queue<Client>();
List<string[]> clientFiles = new List<string[]>();

Client cleber = new Client("Cleber Rocha");
Client felipe = new Client("Felipe Rocha");

clientFiles.Add(cleber.getClientFile());
clientFiles.Add(felipe.getClientFile());

cleber.Birthday = clientFiles[0][0];
cleber.Email = clientFiles[0][1];
cleber.Password = clientFiles[0][2];
cleber.Check();

felipe.Birthday = clientFiles[1][0];
felipe.Email = clientFiles[1][1];
felipe.Password = clientFiles[1][2];
felipe.Check();

/* felipe.Name = "felipe glauco";
felipe.Birthday = "2002/04/14";

felipe.Check(); */

