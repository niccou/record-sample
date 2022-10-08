// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome in the record sample");

Console.WriteLine();

Console.WriteLine("Create a mutable record");

var mutable = CreateMutablePerson();

Console.WriteLine($"{mutable.LastName} {mutable.FirstName} {mutable.Age} yo");

Console.WriteLine();

Console.WriteLine("Create an immutable record");

var immutable = CreateImmutablePerson();

Console.WriteLine($"{immutable.LastName} {immutable.FirstName} {immutable.Age} yo");

Console.WriteLine();

CheckMutableEquality();

Console.WriteLine();

CheckImmutableEquality();

Console.WriteLine();

UpdateMutableRecord();

Console.WriteLine();

UpdateImmutableRecord();

Console.WriteLine();

UpdateMutableRecordCaveat();

Console.WriteLine();

UpdateMutableRecordCaveatWithImmutable();

static MutablePerson CreateMutablePerson()
{
    var bob = new MutablePerson();
    bob.FirstName = "Bob";
    bob.LastName = "Sponge";
    bob.Age = 18;
    return bob;
}

static Person CreateImmutablePerson()
{
    var bob = new Person
    {
        FirstName = "Bob",
        LastName = "Sponge",
        Age = 18
    };
    return bob;
}

static void CheckMutableEquality()
{
    Console.WriteLine("Check Mutable Equality");
    var bob1 = CreateMutablePerson();
    var bob2 = CreateMutablePerson();

    Console.WriteLine($"Checking mutable record equality {nameof(bob1)} == {nameof(bob2)} => {bob1 == bob2}");
}

static void CheckImmutableEquality()
{
    Console.WriteLine("Check Immutable Equality");
    var bob1 = CreateImmutablePerson();
    var bob2 = CreateImmutablePerson();

    Console.WriteLine($"Checking immutable record equality {nameof(bob1)} == {nameof(bob2)} => {bob1 == bob2}");
}

static void UpdateMutableRecord()
{
    Console.WriteLine("Update Mutable Record");
    
    var bob1 = CreateMutablePerson();
    var bob2 = CreateMutablePerson();

    Console.WriteLine($"{nameof(bob1)} {bob1.LastName} {bob1.FirstName} {bob1.Age} yo");
    Console.WriteLine($"{nameof(bob2)} {bob2.LastName} {bob2.FirstName} {bob2.Age} yo");
    Console.WriteLine($"Checking mutable record equality {nameof(bob1)} == {nameof(bob2)} => {bob1 == bob2}");

    Console.WriteLine($"Update {nameof(bob2)}");

    bob2.FirstName += "!!";
    bob2.Age += 10;

    Console.WriteLine($"{nameof(bob1)} {bob1.LastName} {bob1.FirstName} {bob1.Age} yo");
    Console.WriteLine($"{nameof(bob2)} {bob2.LastName} {bob2.FirstName} {bob2.Age} yo");
    Console.WriteLine($"Checking mutable record equality {nameof(bob1)} == {nameof(bob2)} => {bob1 == bob2}");
}

static void UpdateImmutableRecord()
{
    Console.WriteLine("Update Immutable Record");
    
    var bob1 = CreateImmutablePerson();
    var bob2 = CreateImmutablePerson();

    Console.WriteLine($"{nameof(bob1)} {bob1.LastName} {bob1.FirstName} {bob1.Age} yo");
    Console.WriteLine($"{nameof(bob2)} {bob2.LastName} {bob2.FirstName} {bob2.Age} yo");

    Console.WriteLine($"Update {nameof(bob2)}");

    bob2 = bob2 with { FirstName = bob2.FirstName + "!!", Age = bob2.Age + 10};

    Console.WriteLine($"{nameof(bob1)} {bob1.LastName} {bob1.FirstName} {bob1.Age} yo");
    Console.WriteLine($"{nameof(bob2)} {bob2.LastName} {bob2.FirstName} {bob2.Age} yo");
    Console.WriteLine($"Checking immutable record equality {nameof(bob1)} == {nameof(bob2)} => {bob1 == bob2}");
}

static void UpdateMutableRecordCaveat()
{
    Console.WriteLine("Update Mutable Record Caveat");
    
    var bob1 = CreateMutablePerson();
    var bob2 = bob1;

    Console.WriteLine($"{nameof(bob1)} {bob1.LastName} {bob1.FirstName} {bob1.Age} yo");
    Console.WriteLine($"{nameof(bob2)} {bob2.LastName} {bob2.FirstName} {bob2.Age} yo");
    Console.WriteLine($"Checking mutable record equality {nameof(bob1)} == {nameof(bob2)} => {bob1 == bob2}");

    Console.WriteLine($"Update {nameof(bob2)}");

    bob2.FirstName += "!!";
    bob2.Age += 10;

    Console.WriteLine($"{nameof(bob1)} {bob1.LastName} {bob1.FirstName} {bob1.Age} yo");
    Console.WriteLine($"{nameof(bob2)} {bob2.LastName} {bob2.FirstName} {bob2.Age} yo");
    Console.WriteLine($"Checking mutable record equality {nameof(bob1)} == {nameof(bob2)} => {bob1 == bob2}");
}


static void UpdateMutableRecordCaveatWithImmutable()
{
    Console.WriteLine("Update Mutable Record Caveat With Immutable");
    
    var bob1 = CreateImmutablePerson();
    var bob2 = bob1;

    Console.WriteLine($"{nameof(bob1)} {bob1.LastName} {bob1.FirstName} {bob1.Age} yo");
    Console.WriteLine($"{nameof(bob2)} {bob2.LastName} {bob2.FirstName} {bob2.Age} yo");
    Console.WriteLine($"Checking immutable record equality {nameof(bob1)} == {nameof(bob2)} => {bob1 == bob2}");

    Console.WriteLine($"Update {nameof(bob2)}");

    bob2 = bob2 with { FirstName = bob2.FirstName + "!!", Age = bob2.Age + 10};

    Console.WriteLine($"{nameof(bob1)} {bob1.LastName} {bob1.FirstName} {bob1.Age} yo");
    Console.WriteLine($"{nameof(bob2)} {bob2.LastName} {bob2.FirstName} {bob2.Age} yo");
    Console.WriteLine($"Checking immutable record equality {nameof(bob1)} == {nameof(bob2)} => {bob1 == bob2}");
}
