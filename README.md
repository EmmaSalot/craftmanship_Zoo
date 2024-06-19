# Zoo
## Auteurs : Quentin Moskwa & Emma Salot

Structure :  
ZooManager/  
├── animal/  
│ ├── Animal.cs  
│ └── IAnimal.cs  
├── enclos/  
│ ├── Enclos.cs  
│ └── IEnclos.cs  
├── visite/  
│ ├── Visite.cs  
│ └── IVisite.cs  
├── zoo/  
│ ├── Zoo.cs  
│ └── IZoo.cs  

ZooManager.Tests/  
└── UnitTests1.cs  

Le projet est en C# .NET avec des tests unitaires.  
Tous les tests sont dans le fichier UnitTests1.cs.  
Chaque classe et son interface sont dans leur dossier respectif.  

La classe Zoo agit comme la classe "main", elle gère les interactions avec Animal, Enclos et Visite.  
Animal.cs ne gère que les informations des animaux.  
Enclos.cs ne gère que les informations des enclos.  
Visite.cs ne gère que les informations des visites.  
