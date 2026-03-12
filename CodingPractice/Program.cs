using System;
using System.Collections;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.

Stack stack = new Stack();
stack.Push(100);
stack.Push(200);

int value1 = (int)stack.Pop();
int value2 = (int)stack.Pop();

Console.WriteLine($"값1: {value1}, 값2: {value2}");
Console.WriteLine();

Stack<int> stack2 = new();
stack2.Push(100);
stack2.Push(200);

int value3 = (int)stack2.Pop();
int value4 = (int)stack2.Pop();

Console.WriteLine($"값1: {value3}, 값2: {value4}");
Console.WriteLine();

Cup<string> menu = new();
Cup<int> size = new();
menu.Value = "커피";
size.Value = 500;

Console.WriteLine($"음료: {menu.Value}");
Console.WriteLine($"용량: {size.Value}ml");
Console.WriteLine();

var pair1 = new Pair<string, int>();
pair1.first = "용사";
pair1.second = 100;

var pair2 = new Pair<int, double>();
pair2.first = 1;
pair2.second = 95.5;

Console.WriteLine($"이름: {pair1.first}, HP: {pair1.second}");
Console.WriteLine($"순위: {pair2.first}등, 점수: {pair2.second}점");
Console.WriteLine();

void Swap<T>(ref T a, ref T b)
{
    T temp = a;
    a = b;
    b = temp;
}

int x = 10;
int y = 20;

Console.WriteLine($"교환 전: x={x} y={y}");
Swap(ref x, ref y);
Console.WriteLine($"교환 후: x={x} y={y}");

string first = "사과";
string second = "바나나";

Console.WriteLine($"교환 전: first={first} second={second}");
Swap(ref first, ref second);
Console.WriteLine($"교환 후: first={first} second={second}");
Console.WriteLine();

var container1 = new NumberContainer<int>();
container1.Value = 100;

var container2 = new NumberContainer<double>();
container2.Value = 3.14;

Console.WriteLine($"정수값: {container1.Value}");
Console.WriteLine($"실수값: {container2.Value}");
Console.WriteLine();

T CreateInstance<T>() where T : new()
{
    return new T();
}

var monster = CreateInstance<Monster>();
monster.Name = "슬라임";
monster.Hp = 50;

Console.WriteLine($"생성된 몬스터: {monster.Name}, HP: {monster.Hp}");
Console.WriteLine();

T GetMax<T>(T a, T b) where T : IComparable<T>
{
    return a.CompareTo(b) > 0 ? a : b;
}

Console.WriteLine($"더 큰 정수: {GetMax(10, 25)}");
Console.WriteLine($"사전순 뒤: {GetMax("apple", "banana")}");
Console.WriteLine();

T GetDefaultValue<T>()
{
    return default(T);
}

Console.WriteLine($"int 기본값: {GetDefaultValue<int>()}");
Console.WriteLine($"bool 기본값: {GetDefaultValue<bool>()}");
Console.WriteLine($"string 기본값: {GetDefaultValue<string>() ?? "(null)"}");
Console.WriteLine();

var names = new List<string>();
names.Add("철수");
names.Add("영희");
names.Add("민수");

Console.WriteLine("이름 목록:");
foreach (var name in names)
{
    Console.WriteLine($"  - {name}");
}
Console.WriteLine();

var scores  = new Dictionary<string, int>();
scores["철수"] = 95;
scores["영희"] = 88;
scores["민수"] = 92;

Console.WriteLine("점수:");
foreach (var score in scores)
{
    Console.WriteLine($"  {score.Key}: {score.Value}점");
}
Console.WriteLine();

var specialItem = new SpecialContainter<string>();
specialItem.Item = "특별한 아이템";
specialItem.Description = "레어 등급";
Console.WriteLine($"{specialItem.Item} ({specialItem.Description})");

var intItem = new IntContainer();
intItem.Item = 50;
Console.WriteLine($"값: {intItem.Item}, 두 배: {intItem.Double()}");
Console.WriteLine();

Counter<int>.Count++;
Counter<int>.Count++;
Counter<string>.Count++;

Console.WriteLine($"Counter<int>.Count: {Counter<int>.Count}");
Console.WriteLine($"Counter<string>.Count: {Counter<string>.Count}");