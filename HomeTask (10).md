
### Task 1 

Create a new C# project with three classes plus another class to test the logic in your code.                                   
The main classes of the program are the following classes:      

Создайте новый проект C# с тремя классами и еще одним классом для проверки логики вашего кода.
Основными классами программы являются следующие классы:

`Person.cs`
 
- The base class for both Student and Teacher.

- `Public Methods`

    - `Greet()` 🌟: Writes "Hello!" on the screen.
    - `SetAge(int age)` 📅: Assigns the age of the person.

---

`Student.cs`

A class that inherits from Person.

- `Public Methods`

    - `Study()` 📚: Writes "I'm studying" on the screen.
    - `ShowAge()` 🔢: Writes "My age is: x years old" on the screen.

--- 

`Teacher.cs`

A class that inherits from Person.

- Public Methods

    - `Explain()` 📝: Writes "I'm explaining" on the screen.

### Output

```
Hello!
Hello!
My age is 21 years old
I'm studying
Hello!
I'm explaining
```

##

### Task 2

Create a C# program that represents the following UML class diagram. The diagram includes public, private, and protected attributes, as well as class dependency and inheritance.      

Создайте программу C#, которая представляет следующую диаграмму классов UML. Диаграмма включает в себя публичные, частные,
и защищенные атрибуты, а также зависимость и наследование классов.

## Class Diagram

![image](./Images/Screenshot_1.jpg)


In the class diagram:

- The `Shape` class is the base class. It has a private attribute `color` of type `string`.
- The `Rectangle` class inherits from `Shape` and has additional private attributes `length` and `width`, both of type `double`.
- The `Circle` class also inherits from `Shape` and has an additional private attribute `radius` of type `double`.


In this C# implementation:

- The `Shape` class serves as the base class. It has a constructor that initializes the `color` attribute.
- The `Rectangle` class inherits from `Shape` and has its own constructor that initializes the `length` and `width` attributes.
- The `Circle` class also inherits from `Shape` and has its own constructor that initializes the `radius` attribute.

---

В диаграмме классов:

- Класс `Shape` является базовым классом. У него есть частный атрибут `color` типа `string`.
— Класс `Rectangle` наследует от `Shape` и имеет дополнительные частные атрибуты `length` и `width`, оба типа `double`.
- Класс `Circle` также наследует от `Shape` и имеет дополнительный частный атрибут `radius` типа `double`.


В этой реализации С#:

— Класс Shape служит базовым классом. У него есть конструктор, который инициализирует атрибут color.
- Класс Rectangle наследует от Shape и имеет собственный конструктор, который инициализирует атрибуты length и width.
— Класс Circle также наследует от Shape и имеет собственный конструктор, инициализирующий атрибут Radius.

##

### Task 3

Imagine that you are developing a program to control devices in a smart home.                                        
You have different types of devices such as lamps, thermostats, and locks.                                                  
You need to create classes for each device type that implement a common `IDevice` interface.                          

### Requirements

- The classes for each device (e.g., `Lamp`, `Thermostat`, `Lock`) must implement the `IDevice` interface.

- The `IDevice` interface must contain the following methods, which will be implemented by each device according to its functionality:

- `TurnOn()`: Turns on the device.
- `TurnOff()`: Turns off the device.

- Each device must have its own unique properties and methods, which are specific to that device type and different from the `TurnOn` and `TurnOff` methods.

Please implement the classes accordingly to meet the requirements and ensure that each device's functionality is properly implemented.

**`Note`**: Feel free to add additional properties and methods to each device class to enhance their functionality.

---

Представьте, что вы разрабатываете программу для управления устройствами в смарт-доме.                                              
У вас есть различные типы устройств, такие как лампы, термостаты и замки.                                                           
Вам необходимо создать классы для каждого типа устройства, которые будут реализовывать общий интерфейс "IDevice".                                  

### Требования
- Классы для каждого устройства (например, `Lamp`, `Thermostat`, `Lock`) должны реализовывать интерфейс "IDevice".                                           
- Интерфейс "IDevice" должен содержать методы `TurnOn` и `TurnOff`, которые будут реализованы каждым устройством в соответствии с его функциональностью.                 
- У каждого устройства должны быть свои уникальные свойства и методы, отличные от методов `TurnOn` и `TurnOff`.                                   

Пожалуйста, реализуйте классы в соответствии с указанными требованиями и убедитесь, что функциональность каждого устройства корректно реализована.

**`Примечание`**: Вы можете добавить дополнительные свойства и методы в каждый класс устройства, чтобы улучшить его функциональность.

                       


