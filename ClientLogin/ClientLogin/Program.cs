using ClientLogin.Components;

//16, "cleber glauco", "11/01/2000"
Client cleber = new Client("Cleber Rocha");
Client felipe = new Client("Felipe Rocha");

Queue<Client> queue = new Queue<Client>();

string[] lines = cleber.getClientFile();

cleber.Birthday = lines[0];
cleber.Email = lines[1];
cleber.Password = lines[2];

cleber.Check();

felipe.Birthday = lines[0];
felipe.Email = lines[1];
felipe.Password = lines[2];

felipe.Check();

/* felipe.Name = "felipe glauco";
felipe.Birthday = "2002/04/14";

felipe.Check(); */

