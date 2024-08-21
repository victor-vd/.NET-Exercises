using ClientLogin.Components;

//16, "cleber glauco", "11/01/2000"
Client cleber = new Client();
Client felipe = new Client();


cleber.Name = "cleber rocha";
cleber.Birthday = "1998/12/23";
cleber.Email = "cleber1123123213111@gmail.com";
cleber.Password = "QAeBaefUE*¨&fV*)EÄbv)*VB";

cleber.Check();

cleber.Name = "cleber glauco";
cleber.Birthday = "2005/08/19";

cleber.Check();


felipe.Name = "felipe rocha";
felipe.Birthday = "1978/11/13";
felipe.Email = "felipe1123123111@gmail.com";
felipe.Password = "AYV&GHF*)Evb7¨*(&R)";

felipe.Check();

felipe.Name = "felipe glauco";
felipe.Birthday = "2002/04/14";

felipe.Check();

