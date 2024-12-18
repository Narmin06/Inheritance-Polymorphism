#region Task 1
//Human human1 = new Builder("BuilderName", "BuilderSurname", 40, "BuilderCompany");

//Human human2 = new Sailor("SailorName", "SailorSurname", 30, "ShipName", 4);

//Human human3 = new Pilot("PilotName", "PilotSurname", 45, "AirplaneName");

//Human[] human_array = [human1, human2, human3];
//foreach (var human in human_array)
//{
//    human.ShowInfo();
//}
//class Human
//{
//    protected string Name { get; set; }
//    protected string Surname { get; set; }
//    protected int Age { get; set; }
//    public Human(string name, string surname, int age)
//    {
//        Name = name;
//        Surname = surname;
//        Age = age;
//    }
//    public virtual void ShowInfo()
//    {
//        Console.WriteLine($@"Name: {Name}
//Surname: {Surname}
//Age: {Age}
//------------------------------");
//    }
//}

//class Builder : Human
//{
//    public string Company { get; set; }
//    public Builder(string name, string surname, int age, string company) : base(name, surname, age)
//    {
//        Company = company;
//    }
//    public override void ShowInfo()
//    {
//        Console.WriteLine($@"Name: {Name}
//Surname: {Surname}
//Age: {Age}
//Company: {Company}
//------------------------------");
//    }
//}

//class Sailor : Human
//{
//    public string ShipName { get; set; }
//    public int ShipCount { get; set; }
//    public Sailor(string name, string surname, int age, string shipname, int shipcount) : base(name, surname, age)
//    {
//        ShipName = shipname;
//        ShipCount = shipcount;
//    }
//    public override void ShowInfo()
//    {
//        Console.WriteLine($@"Name: {Name}
//Surname: {Surname}
//Age: {Age}
//ShipName: {ShipName}
//ShipCount: {ShipCount}
//------------------------------");
//    }
//}

//class Pilot : Human
//{
//    public string AirplaneName { get; set; }
//    public Pilot(string name, string surname, int age, string airplanename) : base(name, surname, age)
//    {
//        AirplaneName = airplanename;
//    }
//    public override void ShowInfo()
//    {
//        Console.WriteLine($@"Name: {Name}
//Surname: {Surname}
//Age: {Age}
//AirplaneName: {AirplaneName}
//------------------------------");
//    }
//}

#endregion

#region Task 2
//Passport passport1 = new Passport("A1134237", "Narmin Alishova");
//Passport passport2 = new ForeignPassport("A1134237", "Nigar Memmedova","Visa Details", "B98765");
//Passport[] passport_array = [passport1, passport2];
//foreach(var passport in passport_array)
//{
//    passport.ShowInfo();
//    Console.WriteLine("------------------------------------");
//}

//class Passport
//{
//    public string? PassportNumber {  get; set; }
//    public string? Fullname { get; set; }
//    public Passport(string? passportNumber, string? fullname)
//    {
//        PassportNumber = passportNumber;
//        Fullname = fullname;
//    }
//    public virtual void ShowInfo()
//    {
//        Console.WriteLine($@"PassportNumber:{PassportNumber}
//Fullname: {Fullname}");
//    }
//}

//class ForeignPassport : Passport
//{
//    public string VisaInfo {  get; set; }
//    public string ForeignPassportNumber { get; set; }   
//    public ForeignPassport(string passportNumber, string fullName, string visaInfo, string foreingPasswordNumber): base(passportNumber, fullName)
//    {
//        VisaInfo = visaInfo;
//        ForeignPassportNumber = foreingPasswordNumber;
//    }
//    public override void ShowInfo()
//    {
//        base.ShowInfo();
//        Console.WriteLine($@"VisaInfo: {VisaInfo}
//Foreign Password Number: {ForeignPassportNumber}");
//    }
//}

#endregion

#region Task 3

//Animal animal1 = new Tiger("Tiger", 6, "Orange");
//Animal animal2 = new Crocodile("Crocodile", 2, "Water");
//Animal animal3 = new Kangaroo("Kangaroo", 10, "Forest");

//Animal[] animal_array = [animal1, animal2, animal3];
//foreach(Animal animal in animal_array)
//{
//    animal.ShowInfo();
//    animal.MakeSound();
//    Console.WriteLine("-----------------------------------");
//}
//class Animal
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public Animal(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }
//    public virtual void ShowInfo()
//    {
//        Console.WriteLine($@"Name: {Name}
//Age: {Age}");
//    }
//    public virtual void MakeSound()
//    {
//        Console.WriteLine("Some Sound");
//    }
//}

//class Tiger : Animal
//{
//    public string Color {  get; set; }
//    public Tiger(string name, int age, string color) : base(name, age)
//    {
//        Color = color;
//    }
//    public override void ShowInfo()
//    {
//        base.ShowInfo();
//        Console.WriteLine($"Color: {Color}");
//    }
//    public override void MakeSound()
//    {
//        Console.WriteLine("Tiger Sound"); ;
//    }
//}

//class Crocodile : Animal
//{
//    public string LivingWater { get; set; }
//    public Crocodile(string name, int age, string livingwater) : base(name, age)
//    {
//        LivingWater = livingwater;
//    }
//    public override void ShowInfo()
//    {
//        base.ShowInfo();
//        Console.WriteLine($"LivingWater: {LivingWater}");
//    }
//    public override void MakeSound()
//    {
//        Console.WriteLine("Crocodile Sound");
//    }
//}

//class Kangaroo : Animal
//{
//    public string LivingForest { get; set; }
//    public Kangaroo(string name, int age, string livingforest) : base(name, age)
//    {
//        LivingForest = livingforest;
//    }
//    public override void ShowInfo()
//    {
//        base.ShowInfo();
//        Console.WriteLine($"LivingForset: {LivingForest}");
//    }
//    public override void MakeSound()
//    {
//        Console.WriteLine($"Kangaroo Sound");
//    }
//}

#endregion


