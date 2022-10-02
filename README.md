# mvvm-Pattern-EF6 -MSSQL

My project demonstrate generating a DB from a EF6 table diagram of Persons as abstract class which students and teachers inheriting from.
https://github.com/itayG98/mvvm-Pattern-EF6/blob/9b3b10a5abfb49b80adce9055c5135931881f9f2/DimitryExercise2/Model/Model.edmx.diagram#L7-L14
<div align="center">
  
<h3>Diagram</h3>
<img src="https://user-images.githubusercontent.com/91791115/193006315-526ec33b-8384-4313-b8e8-a3b6704caa21.jpg"/>
</div>

### Prerequisites

 1. Use WPF with .NetFramework 4.8
 2. Generated an empty DataBase named `[DimitryExercise2]` in  `(localdb)\mssqllocaldb` in MSSQL
 I added an initial script of sql you can use <a target=_blank href=https://github.com/itayG98/mvvm-Pattern-EF6/blob/master/DB_script/Init_sql_script>here</a>
 3. https://github.com/itayG98/mvvm-Pattern-EF6/blob/9b3b10a5abfb49b80adce9055c5135931881f9f2/DimitryExercise2/App.config#L15-L17

 4. Download Entity Framework from NuGet package manager <a target="_blank" href="https://github.com/dotnet/ef6">Package's Docs</a>
 
 5. In order to run the app you will meed a data to initialize the app you can uncomment this lines in mainWindow.Xaml.cs
 https://github.com/itayG98/mvvm-Pattern-EF6/blob/2b684d093e6f9990e529fa41e50ac4784f2e3eee/DimitryExercise2/MainWindow.xaml.cs#L31-L54
 


<div align="center">
<h3>UI</h3>
<img src="https://user-images.githubusercontent.com/91791115/192984837-15da2c37-ceb8-4fe1-bd69-fcc8494aad29.jpg"/>
</div>
