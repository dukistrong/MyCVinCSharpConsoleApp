using MyCVinCSharpConsoleAppLibrary;

//Basic informations 
Intro me = new Intro();
me.Name = "Dusan";
me.Sur = "Markovic";
me.City = "Gospodjinci";
me.Age = 37;
Console.WriteLine(me.ItsMe());
//Short version of names, titles etc. are used
Education edu = new Education("FTN Novi Sad", "Master in traffic engineering",
    "Ministry of transportation", 
    "Responsible designer of traffic signalisation",
    "Responsible contractor for traffic signalisation",
    "Responsible person for cargo transport",
    "Responsible person for passenger transport",
    "Engineering Chamber of Serbia");
Console.WriteLine(edu.MyEducation());
WorkExperience experience1 = new WorkExperience("Smart Traffic doo", "2022-2022",
    "Licensed traffic engineer", "Project manager", "Field work");
WorkExperience experience2 = new WorkExperience("Verkering doo", "2016-2022",
    "Traffic engineer", "Public bidding", "Field work");
WorkExperience experience3 = new WorkExperience("Worlwide...", "2005-2016",
    "Work on Exit fest", "Hard work in Sweden", "Sumerjobs");
//List of experiences
List<WorkExperience>experiences = new List<WorkExperience>(){experience1, experience2, experience3};
WorkExperience.WorkAsDev();
//User answer about showing work experiences
string answer = Console.ReadLine();
WorkExperience.PrintExperience(experiences, answer);
Other o = new Other();
o.Developing = "C# , Git, .NET, SQL";
Console.WriteLine(o.JustToSay());
Contact contact = new Contact("0665334356", "eat.code.now@gmail.com");
Console.WriteLine(contact.MyContact());
