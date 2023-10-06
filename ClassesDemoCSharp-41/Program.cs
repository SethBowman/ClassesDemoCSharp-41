using ClassesDemoCSharp_41;

//Instance of the classroom class so we can use the list it holds as property
var classroom = new Classroom();

//Instace of a class (use the constructor to actually build an object or instance)

Person seth = new Person();

//Dot notation to fill the values
seth.Name = "Seth";
seth.Age = 29;
seth.HairColor = "black";

//Adding this person to our list
classroom.OurClass.Add(seth);


//Object initializer syntax

var jeremy = new Person() 
{ 
    Name = "Jeremy",
    Age = 30,
    HairColor = "blonde"
};


//Adding this person to our list
classroom.OurClass.Add(jeremy);

//Using a custom constructor

var cruz = new Person("Cruz", 32, "black");

//Adding this person to our list
classroom.OurClass.Add(cruz);

classroom.GetDetails();

