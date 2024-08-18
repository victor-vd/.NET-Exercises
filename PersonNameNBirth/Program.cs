using TestProject.Components;

//16, "cleber glauco", "11/01/2000"
Person cleber = new Person("cleber rocha", "1998/12/23");
Person felipe = new Person("felipe glauco", "2005/08/19");

cleber.name = "cleber glauco";
cleber.Print();

felipe.name = "felipe rocha";

felipe.Print();