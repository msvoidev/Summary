// using System.Collections;
// using System.Collections.Generic;

namespace Summary // Project name
{
    class Program // File name
    {
        static void Main(string[] args)
        {
            // Note 
            /*
                Main() never use or call any Fn, Class, Struct, ...
                Just For getting in touch with unity API and CSharp    
            */
        }


        // Chapter 
        //  One(Getting to Know Your Environment), 
        //  Two(The Building Blocks of Programming)
        //  are introduction,.. !


        // Helper :
        /*
            // + Title
            //      Info
            //  + SubTitle
            //      Info
            //  * Note
            //      Info
        */


        /// <summary>
        /// Diving into Variables, Types, and Methods
        /// </summary>
        public static void Chapter_Three()
        {
            /*
                        /// <summary>
                        /// summary function infos ...
                        /// </summary>
            */
            // Debug.Log("Text goes here.");
            // Debug.LogFormat("Text goes here, add {0} and {1} as variableplaceholders", CurrentAge, FirstName);
            // Debug.Log($"A string can have variables like {FirstName} inserted directly!");

            // + Type and value declarations
            //  int CurrentAge = 32; 

            // + Type-only declarations
            //  int CurrentAge;
            //  CurrentAge = 32;

            // + Using access modifiers
            //  accessModifier dataType UniqueName = value;
            //  accessModifier ==> public, private, protected, internal

            // + Type conversions
            //  + Implicit :
            //     int MyInteger = 3;
            //     float MyFloat = MyInteger;
            //     Debug.Log(MyInteger);
            //     Debug.Log(MyFloat);
            //  + Explicit :
            //     int ExplicitConversion = (int)3.14;

            // + Inferred declarations (like auto but dont know is CT or RT)
            //  var CurrentAge = 32;

            // + Variable scope
            //  * Global scope == refers to a variable that can be accessed by an entire program;
            //  * Class or member scope == refers to a variable that is accessible anywhere in its containing class.
            //  * Local scope == refers to a variable that is only accessible inside the specific block of code it's created in.

            // + Methods
            //  accessModifier returnType UniqueName(parameterType parameterName)
            //  {
            //          method body
            //  }

            // * If there is no explicit access modifier, the method defaults to private
            // * Start() is primarily used to set up variables or perform logic that needs to happen before Update() runs for the first time.

        }


        /// <summary>
        /// Control Flow and Collection Types
        /// </summary>
        public static void Chapter_Four()
        {

            // + The if-else statement
            // if(condition is true)
            // {
            //         Execute this code
            //         block
            // }
            // else
            //     Execute single line of code
            // or
            // else
            // {
            //         Execute this code
            //         block
            // }
            // if (cond) {}
            // else if (cond) {}
            // else {}

            // + The switch statement
            // switch(matchExpression)
            // {
            //     case matchValue1:
            //         Executing code block
            //     break;
            //     case matchValue2:
            //         Executing code block
            //     break;
            //     default:
            //         Executing code block
            //     break;
            // }


            // + Collection types in C# include arrays, dictionaries, and lists

            // + Arrays :
            //  elementType[] name = new elementType[numberOfElements];
            //  int[] topPlayerScores = new int[3];
            // + Longhand initializer
            //  int[] topPlayerScores = new int[] {713, 549, 984};
            //  Shortcut initializer
            //  int[] topPlayerScores = { 713, 549, 984 };

            // + Lists (generic and looks like vector) :
            //  List<elementType> name = new List<elementType>();
            //  List<elementType> name = new List<elementType>() { value1, value2 };
            //  List<string> QuestPartyMembers = new List<string>()
            //      {
            //          "Grim the Barbarian",
            //          "Merlin the Wise",
            //          "Sterling the Knight"
            //      };
            // * with memberFn such as Count, Add, Insert, RemoveAt, Remove, ...

            // + Dictionaries (like map) :
            //  * key-value pairs
            //  Unlike arrays and lists, dictionaries are unordered. 
            //  However, they can be sorted and ordered in various configurations after they are created.
            // Dictionary<keyType, valueType> name = new Dictionary<keyType, valueType>();
            // Dictionary<keyType, valueType> name = new Dictionary<keyType, valueType>()
            //     {
            //         {key1, value1},
            //         {key2, value2}
            //     };
            // * with memberFn such as Count, Add, ContainsKey, Remove, ...


            // + Iteration statements
            //  + for loops :
            //   for (initializer; condition; iterator)
            //   {
            //   code block;
            //   }
            //
            //  List<string> QuestPartyMembers = new List<string>()
            //  { "Grim the Barbarian", "Merlin the Wise", "Sterling the Knight"};
            //  
            //  for (int i = 0; i < QuestPartyMembers.Count; i++)
            //  {
            //  Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);
            //  }

            // + foreach loops :
            //  foreach(elementType localName in collectionVariable)
            //  {
            //      code block;
            //  }
            //
            //  List<string> QuestPartyMembers = new List<string>()
            //      { "Grim the Barbarian", "Merlin the Wise", "Sterling the Knight"};
            //  foreach(string partyMember in QuestPartyMembers)
            //  {
            //      Debug.LogFormat("{0} - Here!", partyMember);
            //  }
            //
            //  Dictionary<string, int> ItemInventory = new Dictionary<string, int>()
            //      {
            //          { "Potion", 5},
            //          { "Antidote", 7},
            //          { "Aspirin", 1}
            //      };
            //  foreach(KeyValuePair<string, int> kvp in ItemInventory)
            //  {
            //      Debug.LogFormat("Item: {0} - {1}g", kvp.Key, kvp.Value);
            //  }

            // + while loops :

            //  initializer... ;
            //  while (condition)
            //  {
            //      code block ... ;
            //      iterator ... ;
            //  }
            //
            //  do 
            //  {
            //    code block to be executed
            //  }
            //  while (condition);
        }


        /// <summary>
        /// Working with Classes, Structs, and OOP
        /// </summary>
        public static void Chapter_Five()
        {
            // + Class
            //      accessModifier class UniqueName
            //      {
            //          Variables
            //          Constructors
            //          Methods
            //      }
            //  
            //      using System.Collections;
            //      using System.Collections.Generic;
            //      using UnityEngine;
            //      public class Character
            //      {
            //          CS class that doest attached to any gObj
            //      }
            // + Instantiating class objects
            //      Character hero = new Character();
            //      with inferred declaration :
            //      var hero = new Character();
            // + Using constructors
            //      public class Character
            //      {
            //          public string name;
            //          public int exp = 0;
            //          public Character()
            //          {
            //              name = "Not assigned";
            //          }
            //          public Character(string name)
            //          {
            //              this.name = name;
            //          }
            //          public void PrintStatsInfo()
            //          {
            //              Debug.LogFormat("Hero: {0} - {1} EXP", name, exp);
            //          }
            //      }
            //  * If a constructor is not specified, C# generates a default one

            // + Declaring structs
            //      accessModifier struct UniqueName
            //      {
            //          Variables
            //          Constructors
            //          Methods
            //      }
            //
            //  ** check refrence passing 
            //  * Variables cannot be initialized with values inside the struct declaration
            //       unless they're marked with the static or const modifier
            //  * Constructors without parameters aren't permitted
            //  * Structs (like Class) come with a default constructor that will automatically set all
            //       variables to their default values according to their type

            // + ( Understanding reference and value types )
            //      Other than keywords and initial field values, we haven't seen much difference
            //       between classes and structs so far. Classes are best suited for grouping together
            //       complex actions and data that will change throughout a program; structs are a better
            //       choice for simple objects and data that will remain constant for the most part. Besides
            //       their uses, they are fundamentally different in one key area—that is, how they are
            //       passed or assigned between variables.
            //   * Classes are reference types, meaning that they are passed by reference;
            //   *    Structs are value types, meaning that they are passed by value.

            // + Reference types
            //  * if we have multiple variables storing the same memory reference, a change to one affects them all
            //  * Assign and Copy will be with ref passing in classes.

            // + Value types
            //  * When a struct object is created, all of its data is stored in its corresponding variable
            //      with no references or connections to its memory location.
            //  * Structs are easily copied and modified as their separate objects,
            //      unlike classes, which retain references to an original object

            // + Integrating the object-oriented mindset {Encapsulation, Inheritance, Polymorphism}
            // + Encapsulation
            //     Access modifiers
            // + Inheritance
            //  * In OOP, we refer to this as inheritance, and it's a powerful way of
            //      creating related classes without having to repeat code
            //  * Any base class members marked with the public,
            //      protected, or internal access modifiers are automatically part of the derived class—
            //      except for constructors. Class constructors always belong to their containing class,
            //      but they can be used from derived classes to keep repeated code to a minimum.
            // + Polymorphism
            //      Polymorphism is the Greek word for many-shaped and applies to OOP in two distinct ways:
            //  * Derived class objects are treated the same as parent class objects. For
            //      example, an array of Character objects could also store Paladin objects, as
            //      they derive from Character.
            //  * Parent classes can mark methods as virtual, meaning that their instructions
            //      can be modified by derived classes using the override keyword. In the case
            //      of Character and Paladin, it would be useful if we could debug different
            //      messages from PrintStatsInfo for each one.
            //

            // + Base constructors
            //      public class ChildClass: ParentClass
            //      {
            //          public ChildClass(): base() // in this case, the default constructor
            //          {
            //          }
            //      }

            // + Composition
            //      Aside from inheritance, classes can be composed of other classes
            //      for example : Add Weapon struct or class to derive class
            //      public class Paladin: Character
            //      {
            //          public Weapon;
            //          public Paladin(string name, Weapon weapon): base(name)
            //          {
            //              this.weapon = weapon;
            //          }
            //      }

            // * Polymorphism allows derived classes to keep the structure of their parent class while
            //      also having the freedom to tailor actions to fit their specific needs. Any method you
            //      mark as virtual will give you the freedom of object polymorphism. 
            // * Base class
            //      public virtual void PrintStatsInfo()
            //      {
            //          Debug.LogFormat("Hero: {0} - {1} EXP", name, exp);
            //      }
            // * Derived class
            //      public override void PrintStatsInfo()
            //      {
            //          Debug.LogFormat("Hail {0} - take up your {1}!", name,
            //          weapon.name);
            //      }

            // Further Reading about Programming Paradigms ==> https://cs.lmu.edu/~ray/notes/paradigms/

            // + Unity 
            //  * Accessing components
            //      1.Through the GetComponent() or Find() methods in the GameObject class,
            //       which work with public and private variables.
            //      2.By dragging and dropping the GameObjects themselves from the Project
            //       panel directly into variable slots in the Inspector tab. This option only works
            //       with public variables in C#, since they are the only ones that will appear
            //       in the Inspector. If you decide you need a private variable displayed in the
            //       Inspector, you can mark it with the SerializeField attribute.
            //      SerializeField ==> https://docs.unity3d.com/ScriptReference/SerializeField.html
            // examples:
            //  GameObject.GetComponent<ComponentType>();
            //  public GameObject DirectionLight;
            //  public Transform LightTransform;
            //  DirectionLight = GameObject.Find("Directional Light");
            //  LightTransform = DirectionLight.GetComponent<Transform>();
            //  GameObject.Find("Directional Light").GetComponent<Transform>();
            // * using drag and drop is better than GameObject.Find()(performance issue).
        }


        // Chapter 
        //  Six(Getting Your Hands Dirty with Unity),
        //  Seven(Movement, Camera Controls, and Collisions),
        //  Eight(Scripting Game Mechanics),
        //  Nine(Basic AI and Enemy Behavior)
        //  interact with Unity Editor.


        /// <summary>
        /// Revisiting Types, Methods, and Classes
        /// </summary>
        public static void Chapter_Ten()
        {
            // + Access modifiers
            //  + const
            //  + readonly
            //  + static
            //  + abstract
            //  + override

            // + Constant and read-only properties
            //      Adding the const keyword after a variable's access modifier
            //       will do just that, but only for built-in C# types. For example, you couldn't mark an
            //       instance of our Character class as a constant. A good candidate for a constant value
            //       is MaxItems in the GameBehavior class:
            //       public const int MaxItems = 4;
            //      The problem you'll run into with constant variables is that they
            //       can only be assigned a value in their declaration, meaning we can't leave MaxItems
            //       without an initial value. As an alternative, we can use readonly, which won't let you
            //       write to the variable, meaning it can't be changed
            //       public readonly int MaxItems;
            //  * Using the readonly keyword to declare a variable will give us the same unmodifiable
            //      value as a constant, while still letting us assign its initial value at any time. A good
            //      place for this would be the Start() or Awake() methods in one of our scripts.
            // + Using the static keyword
            //  * Static classes are sealed, meaning they cannot be used in class inheritance.
            //  * Utility methods are a good case for this situation,
            // Example:
            //  public static class Utilities
            //  {
            //      public static int PlayerDeaths = 0;
            //      public static void RestartLevel()
            //      {
            //          SceneManager.LoadScene(0);
            //          Time.timeScale = 1.0f;
            //      }
            //  }
            //  public void RestartScene()
            //  {
            //      Utilities.RestartLevel();
            //  }
            // * Notice that we didn't need an instance of the Utilities class to 
            //    call the method because it's static—it's just dot notation
            // * Non-static classes can have properties and methods that are static
            //    and non-static. However, if an entire class is marked as static, all
            //    properties and methods must follow suit.

            // + Overloading methods
            //      The term method overloading refers to creating multiple methods with the same
            //       name but with different signatures. A method's signature is made up of its name and
            //       parameters.
            //      Example :
            //       public bool AttackEnemy(int damage) {}
            //        method signature of AttackEnemy() is AttackEnemy(int)
            //  
            //       public static void RestartLevel()
            //       public static bool RestartLevel(int sceneIndex)
            // * Any method can be overloaded as long as its signature differs from the original


            // + ref parameters
            //  * By default, all arguments are passed by value, meaning that a variable passed into
            //     a method will not be affected by any changes that are made to its value inside the
            //     method body. 
            //  * 1.Arguments have to be initialized before being passed into a method.
            //  * 2.You don't need to initialize or assign the reference parameter value before ending the method
            //  * 3.Properties with get or set accessors can't be used as ref or out arguments
            //  Example:
            //   public static int PlayerDeaths = 0;
            //   public static string UpdateDeathCount(ref int countReference) {...}
            //   var message = UpdateDeathCount(ref PlayerDeaths);
            // 
            // + out parameters
            //  * The out keyword does the same job as ref but with different rules, which means
            //     they're similar tools but they're not interchangeable—each has its own use cases:
            //  * 1.Arguments do not need to be initialized before being passed into a method.
            //  * 2.The referenced parameter value does need to be initialized or assigned in the
            //       calling method before it's returned.
            // For instance, we could have replaced ref with out in UpdateDeathCount() as long as
            // we initialized or assigned the countReference parameter before returning from the
            // method:
            //  Example:
            //   public static string UpdateDeathCount(out int countReference) {...}
            // 
            // * Methods that use the out keyword are better suited to situations where you need
            //    to return multiple values from a single function, while the ref keyword works best
            //    when a reference value only needs to be modified. It's also more flexible than the
            //    ref keyword because the initial parameter values don't need to be set before they're
            //    used in the method. The out keyword is especially useful if you need to initialize the
            //    parameter value before you change it. Even though these keywords are a little more
            //    esoteric, it's important to have them in your C# toolkit for special use cases.

            // + Intermediate OOP
            /*
                They'll always be the building blocks of your code, but
                 classes are limited to single inheritance, meaning they can only ever have one parent
                 or superclass, and structs can't inherit at all. So, the question you should be asking
                 yourself right about now is simple: "How can I create objects from the same blueprint and
                 have them perform different actions based on a specific scenario?"
                 To answer this question, we'll be learning about interfaces, abstract classes, and class
                 extensions.
            */

            // + Interfaces 
            //  * Interfaces are blueprints for data and behaviors but with one important
            //      difference: they can't have any actual implementation logic or stored values. 
            //  * You can use interfaces with
            //     both classes and structs, and there's no upper limit to how many interfaces a single
            //     class or struct can adopt.
            //  * Remember, a single class can only have one parent class, and structs can't subclass at all.
            // Example:
            //  public interface IManager (as same as fileNmae)
            //  {
            //      string State { get; set; }
            //      void Initialize();
            //  }
            //  * All interface properties need at least a get accessor 
            //     to compile but can have both get and set accessors if necessary.
            // Example:
            //  public class GameBehavior : MonoBehaviour, IManager
            //  {
            //      private string _state;
            //      public string State // in interface is private
            //      {
            //          get { return _state; }
            //          set { _state = value; }
            //      }
            //      void Start()
            //      {
            //          Initialize();
            //      }
            //      public void Initialize() // in interface is private
            //      {
            //          _state = "Game Manager initialized..";
            //          Debug.Log(_state);
            //      }
            //  }
            //
            // * While we could have done all of this with subclassing, we'd be limited to one parent class for all our managers.

            // + Abstract classes
            //  * Another approach to separating common blueprints and sharing them between
            //      objects is the abstract class. Like interfaces, abstract classes cannot include any
            //      implementation logic for their methods; they can, however, store variable values.
            //  * In situations where you might
            //      need to set initial values, an abstract class would be the way to go.
            //  * Any class that subclasses from an abstract class must fully implement all variables
            //      and methods marked with the abstract keyword. They can be particularly useful in
            //      situations where you want to use class inheritance without having to write out a base
            //      class's default implementation

            // Example:

            //  public abstract class BaseManager
            //  {
            //      protected string _state = "Manager is not initialized..."; // couldn't do in interface
            //      public abstract string State { get; set; } // must be implemented by the subclass
            //      public abstract void Initialize(); // must be implemented by the subclass
            //  }

            // public class CombatManager: BaseManager
            // {
            //     public override string State
            //     {
            //         get { return _state; }
            //         set { _state = value; }
            //     }
            //     public override void Initialize()
            //     {
            //         _state = "Combat Manager initialized..";
            //         Debug.Log(_state);
            //     }
            // }

            /*
            Interfaces will
            allow you to spread and share pieces of functionality between unrelated objects,
            leading to a building block-like assembly when it comes to your code.
            Abstract classes, on the other hand, will let you keep the single-inheritance structure
            of OOP while separating a class's implementation from its blueprint. 
            These approaches can even be mixed and matched, as abstract classes can adopt interfaces
            just like non-abstract ones
            */

            // Further Read ==> 
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface

            
            // + Class extensions
            //  * All extension methods need to be marked as static
            //  * The first parameter needs to be the this keyword, followed by the name of
            //      the class we want to extend and a local variable name
            //     This special parameter lets the compiler identify the method as an
            //      extension, and gives us a local reference for the existing class
            //     Any class methods and properties can then be accessed through the local variable
            //     It's common to store extension methods inside a static class, which, in turn,
            //      is stored inside its namespace. This allows you to control what other scripts
            //      have access to your custom functionality.
            // ** A custom class can also be extended using the same syntax, but it's
            //      more common to just add extra functionality directly into the class
            //      if it's one you control
            // 
            // Example :
            
            //  public static returnType MethodName(this ExtendingClass localVal) {}

            //  using System.Collections;
            //  using System.Collections.Generic;
            //  using UnityEngine;
            //  namespace CustomExtensions
            //  {
            //      public static class StringExtensions
            //      {
            //          public static void FancyDebug(this string str)
            //          {
            //              Debug.LogFormat("This string contains {0} characters.",
            //              str.Length);
            //          }
            //      }
            //  }
            // Extending the entire string class with FancyDebug() means that any string variable
            // has access to it. Since the first extension method parameter has a reference to
            // whatever string value that FancyDebug() is called on, its length will be printed out properly


            // + Namespace conflicts and type aliasing
            //  * Namespace conflicts happen when there are two or more classes or types with the
            //      same name, which happens more than you'd think
            //  * C# has a simple solution to these situations: type aliasing
            //  * You can use type aliasing with your custom types, or existing ones with the same
            //      syntax, as long as they're declared at the top of script files with the other using directives
            // Example :
            //  using AliasName = type;
            //  using CustomInt = System.Int64;
            //  public CustomInt PlayerHealth = 100;

            // Further Reading ==>
            //   https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-directive
        }


        /// <summary>
        /// Introducing Stacks, Queues, and HashSets
        /// </summary>
        public static void Chapter_Eleven()
        {
            // All the collection types in this chapter are a part of the System.
            //  Collections.Generic namespace, meaning you need to add the
            //  following code to the top of any file that you want to use them in:
            // using System.Collections.Generic;

            // + Stacks
            //  * last-in-first-out (LIFO) model
            //  Stack<elementType> name = new Stack<elementType>();
            //  * Stacks can't be initialized with elements when they're created. 
            //      Instead, all elements have to be added after the stack is created.

            //  * C# supports a non-generic version of the stack type that doesn't
            //      require you to define the type of element in the stack:
            //      Stack myStack = new Stack();
            //  * However, this is less safe and more costly than using the preceding generic version
            
            // Example :
            //  public Stack<string> LootStack = new Stack<string>();
            //  LootStack.Push("Sword of Doom");
            //  LootStack.Count 
            
            // + Popping and peeking
            //   * The Peek method returns the next item on the stack without removing it,
            //      letting you "peek" at it without changing anything
            //   * The Pop method returns and removes the next item on the stack, essentially
            //      "popping" it off and handing it to you
            //  var currentItem = LootStack.Pop();
            //  var nextItem = LootStack.Peek();
            // * Common methods == > Clear(), Contains("an item"), ...
            // * Copy the elements of a stack to an array
            //      Creates a new array of the same length as LootStack
            //       string[] CopiedLoot = new string[5];
            //      Copies the LootStack elements into the new CopiedLoot array at index 0.
            //      The index parameter can be set to any index where you want the copied
            //      elements to be stored
            //       LootStack.CopyTo(copiedLoot, 0);
            //
            // * Copies an existing stack to a new array (different than the CopyTo() method)
            //      LootStack.ToArray();

            // + Queues
            //  * first-in-first-out (FIFO) model
            //  Queue<elementType> name = new Queue<elementType>();
            //
            //  * like stack C# supports a non-generic version of the queue type that doesn't
            //      require you to define the type of element it stores:
            //  Queue myQueue = new Queue();
            //  * Common methods ==> Enqueue, Peek, Dequeue, ...
            // Example :
            //  Queue<string> activePlayers = new Queue<string>();
            // Adds string values to the end of the Queue.
            //  activePlayers.Enqueue("Harrison");
            // Returns the first element in the Queue without removing it.
            //  var firstPlayer = activePlayers.Peek();
            // Returns and removes the first element in the Queue.
            //  var firstPlayer = activePlayers.Dequeue();


            // + HashSets
            //  * It cannot store duplicate values and is not sorted,
            //      meaning its elements are not orderedin any way.
            //      Think of HashSets as dictionaries with just keys, instead of key-value pairs
            //  * They can perform set operations and element lookups extremely fast. 
            //  HashSet<elementType> name = new HashSet<elementType>();

            //  * Unlike stacks and queues, you can initialize a HashSet with default values when
            //      declaring the variable:
            //  HashSet<string> people = new HashSet<string>();
            //  OR
            //  HashSet<string> people = new HashSet<string>() { "Joe", "Joan", "Hank"};
            // To add an element
            // people.Add("Walter");
            // To remove an element 
            // people.Remove("Joe");

            // + Performing operations
            //  * Set operations need two things: a calling collection object and a passed-in collection object.
            // ** UnionWith adds the elements of the current and specified sets together
            // ** IntersectWith stores only the elements that are in both the current and specified sets
            // ** ExceptWith subtracts the elements of the specified set from the current set
            // * There are two more groups of set operations that deal with subset and superset computations.

            // Example : 
            
            //  HashSet<string> activePlayers = new HashSet<string>() { "Harrison", "Alex", "Haley"};
            //  HashSet<string> inactivePlayers = new HashSet<string>() { "Kelsey", "Basel"};
            //  activePlayers.UnionWith(inactivePlayers);
            ////  activePlayers now stores "Harrison", "Alex", "Haley", "Kelsey", "Basel"

            //  HashSet<string> activePlayers = new HashSet<string>() { "Harrison", "Alex", "Haley"};
            //  HashSet<string> premiumPlayers = new HashSet<string>() { "Haley", "Basel"};
            //  activePlayers.IntersectWith(premiumPlayers);
            //// activePlayers now stores only "Haley"

            //  HashSet<string> activePlayers = new HashSet<string>() { "Harrison", "Alex", "Haley"};
            //  HashSet<string> premiumPlayers = new HashSet<string>() { "Haley", "Basel"};
            //  activePlayers.ExceptWith(premiumPlayers);
            //// activePlayers now stores "Harrison" and "Alex" but removed "Haley"

            //  * Notice that I'm using brand-new instances of the two example sets
            //      for each operation because the current set is modified after each
            //      operation is executed. If you keep using the same sets throughout,
            //      you will get different result

            // They were just intermediate collections...!

        }


        /// <summary>
        /// Saving, Loading, and Serializing Data
        /// </summary>
        public static void Chapter_Twelve()
        {
            // three most common data formats for working with Unity ==>
            //  Text files,
            //  XML (Extensible Markup Language) and
            //  JSON (JavaScript Object Notation).

            // + Breaking down XML
            //   A typical XML file has a standardized format. Each element of the XML document
            //    has an opening (<element_name>), a closing tag (</element_name>), and supports tag
            //    attributes (<element_name attribute= "attribute_name"></element_name>). A basic
            //    file will start with the version and encoding being used, then the starting or root
            //    element, followed by a list of element items, and finally the closing element. As a
            //    blueprint, it would look like this:

            // <?xml version="1.0" encoding="utf-8"?>
            // <root_element>
            //     <element_item>[Information goes here]</element_item>
            //     <element_item>[Information goes here]</element_item>
            //     <element_item>[Information goes here]</element_item>
            // </root_element>
            
            // List of weapons into XML using the Weapon class :

            // <?xml version="1.0"?>
            // <ArrayOfWeapon>

            //     <Weapon>
            //         <name>Sword of Doom</name>
            //         <damage>100</damage>
            //     </Weapon>
                
            //     <Weapon>
            //         <name>Butterfly knives</name>
            //         <damage>25</damage>
            //     </Weapon>
                
            //     <Weapon>
            //         <name>Brass Knuckles</name>
            //         <damage>15</damage>
            //     </Weapon>
            
            // </ArrayOfWeapon>

            // * C# has an entire library of classes and methods to help us translate simple
            //    text and class objects directly into XML.

            // + Breaking down JSON
            //  * The JSON data format is similar to XML, but without the tags. Instead, everything is
            //      based on attribute-value pairs, like the Dictionary collection type
            //  * Each JSON document starts with a parent dictionary that holds as many attribute-value pairs as you need
            //  * Dictionaries use open and closed curly braces ( { } ),
            //      a colon separates each attribute and value,
            //      and each attribute-value pair is separated by a comma:
            
            // Parent dictionary for the entire file
            // {
                    // List of attribute-value pairs where you store your data
                    // "attribute_name": value,
                    // "attribute_name": value
            // }

            // * JSON can also have child or nested structures by setting the value of an attribute-
            //    value pair to an array of attribute-value pairs. For instance, if we want to store a
            //    weapon, it would look like this:
            // Parent dictionary
            // {
            //        // Weapon attribute with its value set to an child dictionary
            //     "weapon": {
            //            // Attribute-value pairs with weapon data
            //         "name": "Sword of Doom",
            //         "damage": 100
            //     }
            // }

            // * JSON data is often made up of lists, or arrays, or objects.

            // // Parent dictionary
            // {
            //     // List of weapon attribute set to an array of weapon objects
            //     "weapons": [
            //         // Each weapon object stored as its own dictionary
            //         {
            //             "name": "Sword of Doom",
            //             "damage": 100
            //         },
            //         {
            //             "name": "Butterfly knives",
            //             "damage": 25
            //         },
            //         {
            //             "name": "Brass Knuckles",
            //             "damage": 15
            //         }
            //     ]
            // }

            // * C# and Unity both have helper classes and methods
            //      to translate text and class objects into JSON without us having to do any heavy lifting


            // + Understanding the filesystem
            // Example :
            // using System.IO;
            // Debug.LogFormat("Path separator character: {0}", Path.PathSeparator);
            // Debug.LogFormat("Directory separator character: {0}", Path.DirectorySeparatorChar);
            // Debug.LogFormat("Current directory: {0}", Directory.GetCurrentDirectory());
            // Debug.LogFormat("Temporary path: {0}", Path.GetTempPath());

            // Further Read ==>
            //  https://docs.microsoft.com/en-us/dotnet/api/system.io.path
            //  https://docs.microsoft.com/en-us/dotnet/api/system.io.directory

            // + Working with asset paths
            //  * Unity provides a handy pre-configured path as part of the Application class
            //     where you can store persistent game data
            //  * Persistent data means the information is saved and kept each time the program
            //     runs, which makes it ideal for this kind of player information.
            //  * It's important to know that the path to Unity's persistent data
            //     directory is cross-platform, meaning that it's different whether
            //     you're building a game for iOS, Android, Windows, and more.
            // https://docs.unity3d.com/ScriptReference/Application-persistentDataPath.html

            // Example :
            //  private string _dataPath;
            //  void Awake()
            //  {
            //        // a new folder name called Player_Data 
            //      _dataPath = Application.persistentDataPath + "/Player_Data/";
            //      Debug.Log(_dataPath);
            //  }

            // * It's important to note that Application.persistentDataPath can only
            //    be used in a MonoBehaviour method like Awake(), Start(), Update(),
            //    and so on and the game needs to be running for Unity to return a valid path.
            // * C# has a handy method called Combine in the Path class for automatically
            //    configuring path variables.
            // var path = Path.Combine("/Users", "hferrone", "Chapter_12");
            // * This takes care of any potential cross-platform issues with separating characters and
            //    back or forward slashes in paths and directories

            // + Creating and deleting directories
            // ** _dataPath = Application.persistentDataPath + "/Player_Data/"; // ( in Awake() )
            //
            //  public void NewDirectory() // ( in Start() )
            //  {
            //      if(Directory.Exists(_dataPath))
            //      {
            //          Debug.Log("Directory already exists...");
            //          return;
            //      }
            //      Directory.CreateDirectory(_dataPath);
            //      Debug.Log("New directory created!");
            //  }
            //
            //  public void DeleteDirectory()
            //  {
            //      if(!Directory.Exists(_dataPath))
            //      {
            //          Debug.Log("Directory doesn't exist or has already been deleted...");
            //          return;
            //      }
            //      Directory.Delete(_dataPath, true);
            //      Debug.Log("Directory successfully deleted!");
            //  }

            // + Creating, updating, and deleting files
            // https://docs.microsoft.com/en-us/dotnet/api/system.io.file

            /*
            private string _dataPath;
            private string _textFile;

            void Awake()
            {
                _dataPath = Application.persistentDataPath + "/Player_Data/";
                Debug.Log(_dataPath);
                _textFile = _dataPath + "Save_Data.txt";
            }            

            public void NewTextFile()
            {
                if (File.Exists(_textFile))
                {
                    Debug.Log("File already exists...");
                    return;
                }
                File.WriteAllText(_textFile, "<SAVE DATA>\n\n"); // add two new lines with the \n characters
                // the file is closed for us automatically
                Debug.Log("New file created!");
            }

            public void UpdateTextFile()
            {
                if (!File.Exists(_textFile))
                {
                    Debug.Log("File doesn't exist...");
                    return;
                }
                File.AppendAllText(_textFile, $"Game started: {DateTime.Now}\n");
                Debug.Log("File updated successfully!");
            }

            public void ReadFromFile(string filename)
            {
                if (!File.Exists(filename))
                {
                    Debug.Log("File doesn't exist...");
                    return;
                }
                Debug.Log(File.ReadAllText(filename));
            }

            public void DeleteFile(string filename)
            {
                if (!File.Exists(filename))
                {
                    Debug.Log("File doesn't exist or has already been deleted...");
                    return;
                }
                File.Delete(_textFile);
                Debug.Log("File successfully deleted!");
            }

            public void Initialize() // just for showing way of using not best way
            {
                _state = "Data Manager initialized..";
                Debug.Log(_state);
                FilesystemInfo();
                NewDirectory();
                NewTextFile();
                UpdateTextFile();
                ReadFromFile(_textFile);
            }

            */
            
            // + Working with streams
            //  The File class uses Stream objects for us automatically, and there are different Stream
            //   subclasses for different functionality:
            // * Use a FileStream to read and write data to your files
            // * Use a MemoryStream to read and write data to memory
            // * Use a NetworkStream to read and write data to other networked computers
            // * Use a GZipStream to compress data for easier storage and downloading

            // + Managing your Stream resources
            //  * C# has a handy interface called IDisposable that all Stream classes
            //     implement. This interface only has one method, Dispose(), which tells the stream
            //     when to give you back the resources it's been using.

            // + Using a StreamWriter and StreamReader (with use of FileStream objects)
            
            /*
             
            public void WriteToStream(string filename)
            {
                if (!File.Exists(filename))
                {
                    StreamWriter newStream = File.CreateText(filename);
                    newStream.WriteLine("<Save Data> for HERO BORN \n\n");
                    newStream.Close();
                    Debug.Log("New file created with StreamWriter!");
                }
                StreamWriter streamWriter = File.AppendText(filename);
                streamWriter.WriteLine("Game ended: " + DateTime.Now);
                streamWriter.Close();
                Debug.Log("File contents updated with StreamWriter!");
            }

            public void ReadFromStream(string filename)
            {
                if (!File.Exists(filename))
                {
                    Debug.Log("File doesn't exist...");
                    return;
                }
                StreamReader streamReader = new StreamReader(filename);
                Debug.Log(streamReader.ReadToEnd());
            }

            */
            
            // * We've covered the basic features of a 
            //    CRUD (Creating, Reading, Updating, and Deleting) 
            //    application using text files. 

            // + Creating an XMLWriter
            /*

            using System.Collections;
            using System.Collections.Generic;
            using UnityEngine;
            using System.IO;
            using System;
            using System.Xml; // New


            private string _xmlLevelProgress;
            _xmlLevelProgress = _dataPath + "Progress_Data.xml"; // in void Awake()

            public void WriteToXML(string filename)
            {
                if (!File.Exists(filename))
                {
                    FileStream xmlStream = File.Create(filename);
                    XmlWriter xmlWriter = XmlWriter.Create(xmlStream);
                    xmlWriter.WriteStartDocument(); // specify XML version 1.0
                    xmlWriter.WriteStartElement("level_progress"); // root element tag named level_progress
                    for (int i = 1; i < 5; i++)
                    {
                        xmlWriter.WriteElementString("level", "Level-" + i);
                    }
                    xmlWriter.WriteEndElement();
                    xmlWriter.Close();
                    xmlStream.Close();
                }
            }

            WriteToXML(_xmlLevelProgress); // like in void Start();

            // Reading an XML file is no different than reading any other file.
            //  You can call either the readfromfile() or readfromstream() methods

            */


            // + Automatically closing streams
            //  * When you're working with streams, wrapping them in a using statement
            //     automatically closes the stream for you by calling the Dispose() method from the
            //     IDisposable interface we mentioned earlier.
            // Example :
            
            /*

            // The new stream is wrapped in a using statement
            using(StreamWriter newStream = File.CreateText(filename))
            {
                // Any writing functionality goes inside the curly braces
                newStream.WriteLine("<Save Data> for HERO BORN \n");
            }
            
            */


            // + Serializing data
            //  * The act of serializing an object translates the object's entire state into another format
            //  * The act of deserializing is the reverse, taking the data from a file and
            //     restoring it to its former object state


            // ++ serialize and deserialize a list of weapons into XML and JSON

            // + Serializing and deserializing XML
            /*

            using System.Collections;
            using System.Collections.Generic;
            using UnityEngine;
            using System.IO;
            using System;
            using System.Xml;
            using System.Xml.Serialization;


            // Add a serializable attribute to the Weapon class so Unity and C# know the
            //  object can be serialized
            [Serializable]
            public struct Weapon
            {
                // ... No other changes needed ...
            }

            private string _xmlWeapons;
            private List<Weapon> weaponInventory = new List<Weapon>
            {
                new Weapon("Sword of Doom", 100),
                new Weapon("Butterfly knives", 25),
                new Weapon("Brass Knuckles", 15),
            };

            void Awake()
            {
                // ... No other changes needed ...
                _xmlWeapons = _dataPath + "WeaponInventory.xml";
            }

            public void SerializeXML()
            {
                var xmlSerializer = new XmlSerializer(typeof(List<Weapon>));
                using(FileStream stream = File.Create(_xmlWeapons))
                {
                    xmlSerializer.Serialize(stream, weaponInventory);
                }
            }

            SerializeXML(); // in void Start();

            // To Read Back it

            public void DeserializeXML()
            {
                if (File.Exists(_xmlWeapons))
                {
                    var xmlSerializer = new XmlSerializer(typeof(List<Weapon>));

                    using (FileStream stream = File.OpenRead(_xmlWeapons))
                    {
                        // explicit List<Weapon> cast
                        var weapons = (List<Weapon>)xmlSerializer.Deserialize(stream);
                        foreach (var weapon in weapons)
                        {
                            Debug.LogFormat("Weapon: {0} - Damage: {1}",
                            weapon.name, weapon.damage);
                        }
                    }
                }
            }

            DeserializeXML(); // in void Start();

            */
            
            // + Serializing and deserializing JSON
            // * When it comes to serializing and deserializing JSON, Unity and C# aren't completely
            //    in sync. Essentially, C# has its own JsonSerializer class that works the exact same
            //    way as the XmlSerializer class we used in the previous examples.            
            // * Unity uses the System.Text namespace and implements
            //    its own JSON serializer class called JsonUtility
            
            // Read more : https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to#how-to-write-net-objects-as-json-serialize
            
            /*

            using System.Collections;
            using System.Collections.Generic;
            using UnityEngine;
            using System.IO;
            using System;
            using System.Xml;
            using System.Xml.Serialization;
            using System.Text;

            private string _jsonWeapons;
            void Awake()
            {
                _jsonWeapons = _dataPath + "WeaponJSON.json";
            }

            // // Example :
            // public void SerializeJSON()
            // {
            //     Weapon sword = new Weapon("Sword of Doom", 100);
            //     string jsonString = JsonUtility.ToJson(sword, true);
            //     using(StreamWriter stream = File.CreateText(_jsonWeapons))
            //     {
            //         stream.WriteLine(jsonString);
            //     }
            // }

            SerializeJSON(); // in void Start();

            public void SerializeJSON()
            {
                string jsonString = JsonUtility.ToJson(weaponInventory, true);
                using(StreamWriter stream =
                File.CreateText(_jsonWeapons))
                {
                stream.WriteLine(jsonString);
                }
            }

            // Again, because the way Unity handles JSON serialization doesn't support lists
            //  or arrays by themselves. Any list or array needs to be part of a class object for Unity's
            //  JsonUtility class to recognize and handle it correctly.

            // So update files to fix it

            [Serializable]
            public class WeaponShop
            {
                public List<Weapon> inventory;
            }

            public void SerializeJSON()
            {
                WeaponShop shop = new WeaponShop();
                shop.inventory = weaponInventory;
                string jsonString = JsonUtility.ToJson(shop, true);
                using(StreamWriter stream = File.CreateText(_jsonWeapons))
                {
                    stream.WriteLine(jsonString);
                }
            }

            public void DeserializeJSON()
            {
                if(File.Exists(_jsonWeapons))
                {
                    using (StreamReader stream = new StreamReader(_jsonWeapons))
                    {
                        var jsonString = stream.ReadToEnd();
                        var weaponData = JsonUtility.FromJson<WeaponShop>(jsonString);
                        foreach (var weapon in weaponData.inventory)
                        {
                            Debug.LogFormat("Weapon: {0} - Damage: {1}", weapon.name, weapon.damage);
                        }
                    }
                }
            }

            // Notice that we specify that we want to turn our JSON into a
            //  WeaponShop object with the <WeaponShop> syntax before passing in the
            //  JSON string variable


            DeserializeJSON(); // in void Start();

            */

            // * The ToJson() method we're using takes in the sword object we want
            //    to serialize and a Boolean value of true so the string is pretty printed
            //    with proper indenting. If we didn't specify a true value, the JSON
            //    would still print out, it would just be a regular string, which isn't
            //    easily readable

        }


        /// <summary>
        /// Exploring Generics, Delegates, and Beyond
        /// </summary>
        public static void Chapter_Thirteen()
        {

            // + Generics(template)
            // * generic class instance is created at compile time!
            // public class SomeGenericCollection<T> {}
            // SomeGenericCollection<int> highScores = new SomeGenericCollection<int>();

            // Example :
            /*

            using System.Collections;
            using System.Collections.Generic;
            using UnityEngine;

            public class Shop<T>
            {
                public List<T> inventory = new List<T>();
            }

            public class GameBehavior : MonoBehaviour, IManager
            {
                // ... No other changes needed ...
                public void Initialize()
                {
                    var itemShop = new Shop<string>();
                    Debug.Log("There are " + itemShop.inventory.Count + "items for sale.");
                }
            }

            */

            // *** It's worth noting here that generics aren't supported by the Unity
            //      Serializer by default. If you want to serialize generic classes, like
            //      we did with custom classes in the last chapter, you need to add the
            //      Serializable attribute to the top of class, like we did with our
            //      Weapon class. 
            // Read More : https://docs.unity3d.com/ScriptReference/SerializeReference.html


            // + Generic methods
            //  * Can be  included inside either a generic or non-generic class as needed
            // public void GenericMethod<T>(T genericParameter) {}
            // GenericMethod<string>("Hello World!");

            // * Declare a generic method inside a generic class
            // public class SomeGenericCollection<T>
            // {
            //     public void NonGenericMethod(T genericParameter) {}
            // }


            // * When you call a non-generic method that uses a generic type parameter, there's no
            //    issue because the generic class has already taken care of assigning a concrete type:
            // SomeGenericCollection<int> highScores = new SomeGenericCollection<int> ();
            // highScores.NonGenericMethod(35);

            // *** Generic methods can be overloaded and marked as static, just like
            //      non-generic methods. If you want the specific syntax for those
            //      situations, Google it 

            /*
            
            public class Shop<T>
            {
                public List<T> inventory = new List<T>();
                public void AddItem(T newItem)
                {
                    inventory.Add(newItem);
                }
            }

            // in some where
            var itemShop = new Shop<string>();
            itemShop.AddItem("Potion");
            itemShop.AddItem("Antidote");
            Debug.Log("There are " + itemShop.inventory.Count + "items for sale.");

            public int GetStockCount<U>()
            {
                var stock = 0;
                foreach (var item in inventory)
                {
                    if (item is U) // *** IMPORTANT
                    {
                        stock++;
                    }
                }
                return stock;
            }

            */

            // + Constraint type parameters
            // public class SomeGenericCollection<T> where T: ConstraintType {}
            // + constraining rules 
            // * Adding the class keyword would constrain T to types that are classes
            // * Adding the struct keyword would constrain T to types that are structs
            // * Adding an interface, such as IManager, as the type would limit T to types that adopt the interface
            // * Adding a custom class, such as Character, would constrain T to only that class type

            // * If you need a more flexible approach to account for classes that
            //    have subclasses, you can use where T : U, which specifies that the
            //    generic T type must be of, or derive from, the U type.
            //    This is a little advanced.

            // Just for fun, let's constrain Shop to only accept a new type called Collectable:
            /*
            
            using System.Collections;
            using System.Collections.Generic;
            using UnityEngine;

            public class Collectable
            {
                public string name;
            }

            public class Potion : Collectable
            {
                public Potion()
                {
                    this.name = "Potion";
                }
            }

            public class Antidote : Collectable
            {
                public Antidote()
                {
                    this.name = "Antidote";
                }
            }

            public class Shop<T> where T : Collectable {...}

            public int GetStockCount<U>() where U : T
            {
                var stock = 0;
                foreach (var item in inventory)
                {
                    if (item is U)
                    {
                        stock++;
                    }
                }
                return stock;
            }

            // After Updating Shop and others, Usage:

            var itemShop = new Shop<Collectable>();
            itemShop.AddItem(new Potion());
            itemShop.AddItem(new Antidote());
            Debug.Log("There are " + itemShop.GetStockCount<Potion>() + "items for sale.");
    
            */



            // +++ Adding generics to Unity objects
            //  * Generics also work with Unity scripts and GameObjects.
            
            // For example, we can easily
            //  create a generic destroyable class to use on any MonoBehaviour or object Component we
            //  want to delete from the scen
            /*
            
            using System.Collections;
            using System.Collections.Generic;
            using UnityEngine;

            public class Destroyable<T> : MonoBehaviour where T : MonoBehaviour
            {
                public int OnscreenDelay;
                void Start()
                {
                    Destroy(this.gameObject, OnscreenDelay);
                }
            }

            public class BulletBehavior : Destroyable<BulletBehavior>
            {
            }

            */

            // + Delegating (like std::function but with some extended features)
            //  * There will be times when you need to pass off, or delegate, the execution of a method
            //     from one file to another. In C#, this can be accomplished through delegate types,
            //     which store references to methods and can be treated like any other variable
            //  ** The delegate itself and any assigned method need to have the same signature
            
            // Creating a delegate is a mix between writing a function and declaring a variable:
            // public delegate returnType DelegateName(int param1, string param2);
            
            // This syntax only declares the delegate type itself; to use it,
            //  you need to create an instance as we do with classes:
            // public DelegateName someDelegate;

            // With a delegate type variable declared, it's easy to assign a method that matches the
            //  delegate signature:
            // public DelegateName someDelegate = MatchingMethod;
            // public void MatchingMethod(int param1, string param2)
            // {
            //     // ... Executing code here ...
            // }

            // * Notice that you don't include the parentheses when assigning MatchingMethod to the
            //    someDelegate variable, as it's not calling the method at this point. What it's doing
            //    is delegating the calling responsibility of MatchingMethod to someDelegate, which
            //    means we can call the function as follows:            
            // someDelegate();

            // Example: ( Creating a debug delegate )
            // public delegate void DebugDelegate(string newText);
            // public DebugDelegate debug = Print;
            // public static void Print(string newText)
            // {
            //     Debug.Log(newText);
            // }

            // * In Unity, we've already worked with examples of delegation by using the
            //    OnCollisionEnter() and OnCollisionExit() methods, which are methods that are
            //    called through delegation.
            // * In the real world, custom delegates are most useful when paired with events

            // + Delegates as parameter types (delegation chain)
            // public void LogWithDelegate(DebugDelegate del)
            // {
            //     del("Delegating the debug task...");
            // }
            //
            // LogWithDelegate(debug); // somewhere

            // + Events ( Publish Subscribe Event Systems )
            //  * C# events allow you to essentially create a subscription system based on actions in
            //     your games or apps. For instance, if you wanted to send out an event whenever an
            //     item is collected, or when a player presses the spacebar, you could do that. However,
            //     when an event fires, it doesn't automatically have a subscriber, or receiver, to handle
            //     any code that needs to execute after the event action.
            //  * Any class can subscribe or unsubscribe to an event through the calling class the
            //     event is fired from; just like signing up to receive notifications on your phone when
            //     a new post is shared on Facebook, events form a kind of distributed-information
            //     superhighway for sharing actions and data across your application.
            //  * Declaring events is similar to declaring delegates in that an event has a specific
            //     method signature. We'll use a delegate to specify the method signature we want the
            //     event to have, then create the event using the delegate type and the event keyword:  
            // public delegate void EventDelegate(int param1, string param2);
            // public event EventDelegate eventInstance;
            //  * This setup allows us to treat eventInstance as a method because it's a delegate type,
            //     which means we can send it out at any time by calling it:
            // eventInstance(35, "John Doe");


            // + Creating and invoking events
            /*

            public class PlayerBehavior : MonoBehaviour
            {
                // ... No other variable changes needed ...
                public delegate void JumpingEvent();
                public event JumpingEvent playerJump;
                void Start()
                {
                    // ... No changes needed ...
                }
                void Update()
                {
                    // ... No changes needed ...
                }

                void FixedUpdate()
                {
                    if(IsGrounded() && _isJumping)
                    {
                        _rb.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);
                        playerJump();
                    }
                }
                // ... No changes needed in IsGrounded or OnCollisionEnter
            }

            */

            // * The playerJump event is sent out to all of its
            //    subscribers to notify them of the action.
            // * After the event fires, it's up to its subscribers to process it and do any additional
            //    operations, which we'll see in the Handling event subscriptions section

            // + Handling event subscriptions
            // * Right now, our playerJump event has no subscribers, but changing that is simple
            //    and very similar to how we assigned method references to delegate types in the last
            //    section:
            // someClass.eventInstance += EventHandler;
            // * A reference to the event-containing class is necessary for subscriptions.
            // * The += operator is used to assign a method that will fire when an event executes
            // * The method signature of the event handler method must match the event's type
            // Example :
            // public void EventHandler(int param1, string param2) {}

            // * In cases where you need to unsubscribe from an event, you simply do the reverse of
            //    the assignment by using the -= operator:
            //    someClass.eventInstance -= EventHandler;

            // ** Event subscriptions are generally handled when a class is
            //    initialized or destroyed, making it easy to manage multiple events
            //    without messy code implementations.

            // Example :
            /*

            public class GameBehavior : MonoBehaviour, IManager
            {
                public PlayerBehavior playerBehavior;
                void OnEnable()
                {
                    GameObject player = GameObject.Find("Player");
                    playerBehavior = player.GetComponent<PlayerBehavior>();
                    playerBehavior.playerJump += HandlePlayerJump;
                    debug("Jump event subscribed...");
                }
                public void HandlePlayerJump()
                {
                    debug("Player has jumped...");
                }
                // ... No other changes ...
            }

            */
            // * We then assigned a method to the playerJump event that will execute 
            //    whenever the event is received, and complete the subscription process.

            // ** OnEnable is a method in the MonoBehaviour class, so
            //     all Unity scripts have access to it. This is a great place to
            //     put event subscriptions instead of Awake because it only
            //     executes when the object is active, not just in the process
            //     of loading.

            // + Cleaning up event subscriptions
            //  * Even though our player is never destroyed in our prototype, that's a common feature
            //     in games when you lose. It's always important to clean up event subscriptions
            //     because they take up allocated resources 

            // * We don't want any subscriptions hanging around after the subscribed object has
            //    been destroyed, so let's clean up our jumping event
            
            /*
            private void OnDisable()
            {
                playerBehavior.playerJump -= HandlePlayerJump;
                debug("Jump event unsubscribed...");
            }
            */
            
            // * Any cleanup code you need to write should generally go in this
            //    method, as it executes when the object the script is attached to is inactive
            // * Script properly subscribes and unsubscribes to an event when the
            //    GameObject is enabled and disabled, leaving no unused resources in our game scene.    


            // + Handling exceptions
            //  + Throwing exceptions
            //   * Throwing exceptions is part of something called
            //      defensive programming, which essentially means that you actively and consciously
            //      guard against improper or unplanned operations in your code. To mark those
            //      situations, you throw out an exception from a method that is then handled by the
            //      calling code.

            // Example :
            /*
            public void ValidateEmail(string email)
            {
                if(!email.Contains("@"))
                {
                    throw new System.ArgumentException("Email is invalid");
                }
            }
            */

            // * ArgumentException is a subclass of the Exception class and is accessed through
            //    the System class shown previously. C# comes with many built-in exception types,
            //    including subclasses for checking for null values, out or range collection values, and
            //    invalid operations. Exceptions are a prime example of using the right tool for the
            //    right job. Our example only needs the basic ArgumentException, but you can find
            //    the full descriptive list at https://docs.microsoft.com/en-us/dotnet/api/system.
            //    exception#Standard.

            // Example :
            /*
            public static class Utilities
            {
                // ... No changes needed ...
                public static bool RestartLevel(int sceneIndex)
                {
                    if(sceneIndex < 0)
                    {
                        throw new System.ArgumentException("Scene index cannot be negative");
                    }
                    Debug.Log("Player deaths: " + PlayerDeaths);
                    string message = UpdateDeathCount(ref PlayerDeaths);
                    Debug.Log("Player deaths: " + PlayerDeaths);
                    Debug.Log(message);
                    SceneManager.LoadScene(sceneIndex);
                    Time.timeScale = 1.0f;
                    return true;
                }
            }
            */

            // * Exception is fired before any of the scene manager logic
            //    is executed. We don't have any other scenes configured in our game at the moment,
            //    but this defensive code acts as a safeguard and doesn't let us take an action that might
            //    crash the game (Unity doesn't support negative indexes when loading scenes).

            // + Using try-catch
            //  try
            //  {
            //      // Call a method that might throw an exception
            //  }
            //  catch (ExceptionType localVariable)
            //  {
            //      // Catch all exception cases individually
            //  }

            // * You can chain as many catch statements after the try block as you need to handle
            //    multiple exceptions thrown from a single method, provided they are catching
            //    different exceptions. 
            // For example:
            //  try
            //  {
            //      // Call a method that might throw an exception
            //  }
            //  catch (ArgumentException argException)
            //  {
            //      // Catch argument exceptions here
            //  }
            //  catch (FileNotFoundException fileException)
            //  {
            //      // Catch exceptions for files not found here
            //  }

            // * There's also an optional finally block that can be declared after any catch
            //    statements that will execute at the very end of the try-catch statement, regardless of
            //    whether an exception was thrown:
            //  finally
            //  {
            //      // Executes at the end of the try-catch no matter what
            //  }

            // Example : (Just for showing)
            /*
            public void RestartScene()
            {
                try
                {
                    Utilities.RestartLevel(-1);
                    debug("Level successfully restarted...");
                }
                catch (System.ArgumentException exception)
                {
                    Utilities.RestartLevel(0);
                    debug("Reverting to scene 0: " + exception.ToString());
                }
                finally
                {
                    debug("Level restart has completed...");
                }
            }
            */

            // * It's important to understand how to work with exceptions, but you shouldn't get into
            //    the habit of putting them everywhere in your code. This will lead to bloated classes
            //    and might affect the game's processing time. Instead, you want to use exceptions
            //    where they are most needed—invalidation or data processing, rather than game mechanics.

        }


        /// <summary>
        /// The Journey Continues
        /// </summary>
        public static void Chapter_Fourteen()   
        {

            // ++ More Topics in CSharp

            // + Diving deeper (programming journey with C#, regardless of whether it's with Unity)
            //  * Optional and dynamic variables
            //  * Debugging approaches
            //  * Concurrent programming
            //  * Networking and RESTful APIs
            //  * Recursion and reflection
            //  * Design patterns
            //  * LINQ
            //  * Functional programming

            // + Object-oriented programming and beyond
            //  * functional and reactive programming

            // + Design patterns
            //  * Google it

            // + Approaching Unity projects
            //  * Shaders and effects
            //  * Scriptable objects
            //  * Editor extension scripting
            //  * Non-programmatic UI
            //  * ProBuilder and Terrain tools
            //  * PlayerPrefs and saving data
            //  * Model rigging
            //  * Animator states and transitions
            
            // + C# and Unity resources
            //  * C# Corner: https://www.c-sharpcorner.com
            //  * Dot Net Perls: http://www.dotnetperls.com
            //  * Unity Forum: https://forum.unity.com
            //  * Unity Learn: https://learn.unity.com
            //  * Unity Answers: https://answers.unity.com
            //  * Unity Discord channel: https://discord.com/invite/unity
            //  + YouTube
            //   * Brackeys: https://www.youtube.com/user/Brackeys
            //   * Sykoo: https://www.youtube.com/user/SykooTV/videos
            //   * Renaissance Coders: https://www.youtube.com/channel/UCkUIs-
            //   * k38aDaImZq2Fgsyjw
            //   * BurgZerg Arcade: https://www.youtube.com/user/BurgZergArcade


            // + Unity certifications (for Game Industry)
            //  * Certified Associate
            //  * Certified User: Programmer
            //  * Certified Programmer
            //  * Certified Artist
            //  * Certified Expert – Gameplay Programmer
            //  * Certified Expert – Technical Artist: Rigging and Animation
            //  * Certified Expert – Technical Artist: Shading and Effects
            

            // Last But Not Least:
            // Programming is more a mindset and contextual framework than syntax memorization.
            //  Keep training your brain to think like a programmer and eventually,
            //  you won't be able to see the world any differently



        }

    }

}
