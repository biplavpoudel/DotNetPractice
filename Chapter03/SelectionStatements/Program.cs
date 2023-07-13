object o = "3";
o = 3;
int j = 4;
if (o is int i)    //pattern matching; 'is' operator checks if 'o' can be cast to int. if cast successful, assignment is done inherently.
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("o is not an int so it cannot multiply!");
}

int num = Random.Shared.Next(0, 5);
WriteLine(num);


var animals = new Animal?[]    //or Animal?[] animals = new Animal?[]
{
    new Cat { Name = "Karen", Born = new(year: 2022, month: 8, day: 23), Legs = 4, isDomestic = true },
    null,
    new Cat { Name = "Mufasa", Born = new(year: 1994, month: 6, day: 12) },
    new Spider { Name = "Sid Vicious", Born = DateTime.Today, isVenomous = true},
    new Spider { Name = "Captain Furry", Born = DateTime.Today }
};

foreach (Animal? animal in animals)
{
    string message;
    //switch (animal)
    //{
    //    case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
    //        message = $"The cat named {fourLeggedCat.Name} has four legs.";
    //        break;
    //    case Cat wildCat when wildCat.isDomestic == false:
    //        message = $"The non-domestic cat is named {wildCat.Name}.";
    //        break;
    //    case Cat cat:
    //        message = $"The cat is named {cat.Name}.";
    //        break;
    //    default: // default is always evaluated last
    //        message = $"The animal named {animal.Name} is a {animal.GetType()}.";
    //        break;
    //    case Spider spider when spider.isVenomous:
    //        message = $"The {spider.Name} spider is poisonous. Run!";
    //        break;
    //    case null:
    //        message = "The animal is null.";
    //        break;
    //}
    //WriteLine($"switch statement: {message}");

    message = animal switch
    {
        Cat fourLeggedCat when fourLeggedCat.Legs == 4
        => $"The cat {fourLeggedCat.Name} has four legs.",
        Cat wildCat when wildCat.isDomestic == false
        => $"The non-domestic cat is named {wildCat.Name}.",
        Cat cat
        => $"The cat is named {cat.Name}.",
        Spider spider when spider.isVenomous
        => $"The {spider.Name} spider is poisonous. Run!",
        null
        => "The animal is null.",
        _
        => $"The animal named {animal.Name} is a {animal.GetType().Name}."
    };
    WriteLine($"switch expression: {message}");
}

