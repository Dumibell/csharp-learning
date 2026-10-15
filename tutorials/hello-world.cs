Console.WriteLine("Hello, World!");

string aFriend = "Bill";
Console.WriteLine(aFriend);

aFriend = "Maira";
Console.WriteLine(aFriend);

Console.WriteLine("Hello " + aFriend);

Console.WriteLine($"Hello {aFriend}");

string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

// Trim whitespace from a string
string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

// Replace a word in a string
string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));


//비슷한 두 가지 메서드 StartsWith 와 EndsWith문자열의 부분 문자열도 검색합니다. 이러한 메서드는 문자열의 시작 또는 끝에서 부분 문자열을 찾습니다. StartsWith대신 EndsWith 및 Contains 사용하도록 이전 샘플을 수정해 보세요. 문자열의 시작 부분에서 "You" 또는 "goodbye"를 검색합니다. 문자열의 끝에서 "hello" 또는 "goodbye"를 검색합니다.
Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.EndsWith("hello"));
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(sayHello.Contains("goodbye"));