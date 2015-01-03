## :book: C# Style Guidelines :book:

These style guidelines are more or a copy the C♯ Coding Style Guide Version 0.3 by Mike Krüger, mike@icsharpcode.net.  These style guidelines be simplified and adapted more over time to match the need for MFM.

Basically, the code should be easy to read.  Variable names should point out the type of the variable and be descriptive, but not too long.  Function names should be kept short and not too many empty lines should be inserted.

## About the C# Coding Style Guide ##
This document may be read as a guide to writing robust and reliable programs. It focuses on programs written in C ♯, but many of the rules and principles are useful even if you write in another programming language.

## File Organization ##

### C♯ Source Files ###
Keep your classes/files short, don't exceed 2000 LOC, divide your code up, make structures clearer. Put every class in a separate file and name the file like the class name (with `.cs` as extension of course). This convention makes things much easier.

### Directory Layout ###
Create a directory for every namespace. (For `MyProject.TestSuite.TestTier` use `MyProject/TestSuite/TestTier` as the path, do not use the namespace name with dots.) This makes it easier to map namespaces to the directory layout.

## Indentation ##

### Wrapping Lines ###
When an expression will not fit on a single line, break it up according to these general principles:

- Break after a comma.
- Break after an operator.
- Prefer higher-level breaks to lower-level breaks.
- Align the new line with the beginning of the expression at the same level on the previous line.

Example of breaking up method calls:

```c#
longMethodCall( expr1, expr2,
                expr3, expr4, expr5 );
```

Examples of breaking an arithmetic expression:

PREFER:

```c#
var = a * b / ( c - g + f ) +
      4 * z;
```

BAD STYLE – AVOID:

```c#
var = a * b / ( c - g +
 	  f ) + 4 * z;
```

The first is preferred, since the break occurs outside the parenthesized expression (higher level rule). Note that you indent with tabs to the indentation level and then with spaces to the breaking position in our example this would be:

```c#
> var = a * b / ( c - g + f ) +
> ......4 * z;
```

Where '>' are tab chars and '.' are spaces. (the spaces after the tab char are the indent with of the tab). A good coding practice is to make the tab and space chars visible in the editor which is used.

### White Spaces ###
An indentation standard using spaces never was achieved. Some people like 2 spaces, some prefer 4 and others die for 8, or even more spaces. Better use tabs. Tab characters have some advantages:

- Everyone can set their own preferred indentation level
- It is only 1 character and not 2, 4, 8 … therefore it will reduce typing (even with smart indenting you have to set the indentation manually sometimes, or take it back or whatever)
- If you want to increase the indentation (or decrease), mark one block and increase the indent level with Tab with Shift-Tab you decrease the indentation. This is true for almost any text editor.

Here, we define the Tab as the standard indentation character.

**Don't use spaces for indentation - use tabs!**

## Comments ##
### Block Comments ###
Block comments should usually be avoided. For descriptions use of the /// comments to give C ♯ standard descriptions is recommended. When you wish to use block comments you should use the following style :

```c#
/* Line 1
 * Line 2
 * Line 3
 */
```

As this will set off the block visually from code for the (human) reader. Alternatively you might use this oldfashioned C style for single line comments, even though it is not recommended. In case you use this style, a line break should follow the comment, as it is hard to see code preceeded by comments in the same line:

```c#
/* blah blah blah */
```

Block comments may be useful in rare cases, refer to the TechNote 'The fine Art of Commenting' for an example. Generally block comments are useful for comment out large sections of code.

### Single Line Comments ###
You should use the // comment style to "comment out" code (SharpDevelop has a key for it, Alt+/) . It may be used for commenting sections of code too.

Single line comments must be indented to the indent level when they are used for code documentation. Commented out code should be commented out in the first line to enhance the visibility of commented out code.

A rule of thumb says that generally, the length of a comment should not exceed the length of the code explained by too much, as this is an indication of too complicated, potentially buggy, code.

### Documentation Comments ###
In the .net framework, Microsoft has introduced a documentation generation system based on XML comments. These comments are formally single line C♯ comments containing XML tags. They follow this pattern for single line comments:

```c#
/// <summary>
/// This class...
/// </summary>
```

Multi-line XML comments follow this pattern:

```c#
/// <exception cref=”BogusException”>
/// This exception gets thrown as soon as a
/// Bogus flag gets set.
/// </exception>
```

All lines must be preceded by three slashes to be accepted as XML comment lines. Tags fall into two categories:

- Documentation items
- Formatting/Referencing

The first category contains tags like `<summary>`, `<param>` or `<exception>`. These represent items that represent the elements of a program's API which must be documented for the program to be useful to other programmers. These tags usually have attributes such as name or cref as demonstrated in the multi-line example above. These attributes are checked by the compiler, so they should be valid. The latter category governs the layout of the documentation, using tags such as `<code>`, `<list>` or `<para>`.

Documentation can then be generated using the 'documentation' item in the #develop 'build' menu. The documentation generated is in HTMLHelp format.
For a fuller explanation of XML comments see the Microsoft .net framework SDK documentation. For information on commenting best practice and further issues related to commenting, see the TechNote 'The fine Art of Commenting'.

## Declarations ##

### Number of Declarations per Line ###
One declaration per line is recommended since it encourages commenting. In other words,

```c#
int level; // indentation level
int size; // size of table
```

Do not put more than one variable or variables of different types on the same line when declaring them. Example:

```c#
int a, b; //What is 'a'? What does 'b' stand for?
```

Of course, using self-explanatory variable names such as `indentLevel` make these comments obsolete.  The above example also demonstrates the drawbacks of non-obvious variable names. Be clear when naming variables. 

### Initialization ###
Try to initialize local variables as soon as they are declared. For example:

```c#
string name = myObject.Name;
```

or

```c#
int val = time.Hours;
```

Note: If you initialize a dialogue try to use the using statement:

```c#
using ( OpenFileDialog openFileDialog = new OpenFileDialog( ) ) {
	...
}
```

### Class and Interface Declarations ###
When coding C♯ classes and interfaces, the following formatting rules should be followed:

- No space between a method name and the parenthesis "(" starting its parameter list.
- The opening brace "{" appears in the next line after the declaration statement.
- The closing brace " }" starts a line by itself indented to match its corresponding opening brace.

For example :

```c#
class MySample : MyClass, IMyInterface
{
	int myInt;
	
	public MySample( int myInt )
	{
		this.myInt = myInt;
	}
	
	void Inc( )
	{
		++myInt;
	}
	
	void EmptyMethod( )
	{
	}
}
```

## Statements ##
### Simple Statements ###
Each line should contain only one statement.

### Return Statements ###
A return statement should not use outer most parentheses.

Don't use : `return ( n * (n + 1) / 2 );`

use : `return n * (n + 1) / 2;`

### If, if-else, if else-if else Statements ###
`if`, `if-else` and `if else-if else` statements should look like this:

```c#
if ( condition ) {
	DoSomething( );
	...
}

if ( condition ) {
	DoSomething( );
	...
} else {
	DoSomethingOther( );
	...
}

if ( condition ) {
	DoSomething( );
	...
} else if ( condition ) {
	DoSomethingOther( );
	...
} else {
	DoSomethingOtherAgain( );
	...
}
```

### For / Foreach Statements ###
A for statement should have following form:

```c#
for ( int i = 0; i < 5; ++i ) {
	...
}
```

or single lined (consider using a while statement instead):

```c#
for ( initialization; condition; update ) ;
```

A foreach should look like:

```c#
foreach ( int i in IntList ) {
	...
}
```

Note: Generally use brackets even if there is only one statement in the loop.

### While / Do-While Statements ###
A while statement should be written as follows:

```c#
while ( condition ) {
	...
}
```

An empty while should have the following form:

```c#
while ( condition ) ;
```

A do-while statement should have the following form:

```c#
do {
	...
} while ( condition );
```

### Switch Statements ###
A switch statement should be of following form:

```c#
switch ( condition ) {
	case A:
		...
		break;
	case B:
		...
		break;
	default:
		...
		break;
}
```

### Try-catch Statements ###
A try-catch statement should follow this form:

```c#
try {
	...
} catch ( Exception ) {}
```

or

```c#
try {
	...
} catch ( Exception e ) {
	...
}
```

or

```c#
try {
	...
} catch ( Exception e ) {
	...
} finally {
	...
}
```

## White Space ##
### Blank Lines ###
Blank lines improve readability. They set off blocks of code which are in themselves logically related. Two blank lines should always be used between:

- Logical sections of a source file
- Class and interface definitions (try one class/interface per file to prevent this case)

One blank line should always be used between:
- Methods
- Properties
- Local variables in a method and its first statement
- Logical sections inside a method to improve readability

Note that blank lines must be indented as they would contain a statement this makes insertion in these lines much easier.

### Inter-term spacing ###
There should be a single space after a comma or a semicolon, for example:

```c#
TestMethod( a, b, c ); 
```

don't use : 

```c#
TestMethod(a,b,c)
```

or

```c#
TestMethod(a, b, c);
```

Single spaces surround operators (except unary operators like increment or logical not), example:

```c#
a = b; // don't use a=b;
for ( int i = 0; i < 10; ++i ) // don't use for ( int i=0; i<10; ++i )
							   //           or
							   //           for(int i=0;i<10;++i)
```

## Naming Conventions ##
### Capitalization Styles ###
#### Pascal Casing ####
This convention capitalizes the first character of each word (as in `TestCounter`).

#### Camel Casing ####
This convention capitalizes the first character of each word except the first one. E.g. `testCounter`.

#### Upper Case ####
Only use all upper case for identifiers if it consists of an abbreviation which is one or two characters long, identifiers of three or more characters should use Pascal Casing instead. For Example:

```c#
public class Math
{
	public const PI = ...
	public const E = ...
	public const FeigenBaumNumber = ...
}
```

### Naming Guidelines ###
Generally the use of underscore characters inside names and naming according to the guidelines for Hungarian notation are considered bad practice.

Hungarian notation is a defined set of pre and postfixes which are applied to names to reflect the type of the variable. 

```c#
ListView lvDragSource = null;  // the list view from which has been dragged
Color DragColor = Color.Red;  // the color of the item which has been dragged
string strCollectionType = "Miscellaneous";  // the active collection type
MediaInfo miThis = new MediaInfo( );  // detailed information about the video file from MediaInfo
bool indistinguishable = false;
Regex rgxVideoExtensions;  // to find the main files
```

And remember: a good variable name describes the semantic.  All fields and variable names that contain GUI elements like buttons should be prefixed with their type abbreviations. For example:

```c#
System.Windows.Forms.Button btnCancel;
System.Windows.Forms.TextBox tbName;
```

#### Class Naming Guidelines ####
- Class names must be nouns or noun phrases.
- Use Pascal Casing
- Do not use any class prefix

#### Interface Naming Guidelines ####
- Name interfaces with nouns or noun phrases or adjectives describing behaviour. (Example `IComponent` or `IEnumberable`)
- Use Pascal Casing
- Use I as prefix for the name, it is followed by a capital letter (first char of the interface name)

#### Enum Naming Guidelines ####
- Use Pascal Casing for enum value names and enum type names
- Don’t prefix (or suffix) a enum type or enum values
- Use singular names for enums
- Use plural name for bit fields.

#### ReadOnly and Const Field Names ####
- Name static fields with nouns, noun phrases or abbreviations for nouns
- Use Pascal Casing

#### Parameter / Non Const Field Names ###
- Do use descriptive names, which should be enough to determine the variable meaning and it’s type. But prefer a name that’s based on the parameter’s meaning.
- Use Camel Casing

#### Variable Names ####
- Counting variables are preferably called `i, j, k, l, m, n` when used in 'trivial' counting loops.
- Use Camel Casing

#### Method Names ####
- Name methods with verbs or verb phrases.
- Use Pascal Casing

#### Property Names ####
- Name properties using nouns or noun phrases
- Use Pascal Casing
- Consider naming a property with the same name as it’s type

#### Event Names ####
- Name event handlers with the `EventHandler` suffix.
- Use two parameters named `sender` and `e`
- Use Pascal Casing
- Name event argument classes with the `EventArgs` suffix.
- Name event names that have a concept of pre and post using the present and past tense.
- Consider naming events using a verb.

#### Capitalization summary ####

|Type | Case | Notes|
|-----|------|------|
|Class / Struct | Pascal Casing | | 
|Interface | Pascal Casing | Starts with `I`| 
|Enum values | Pascal Casing| | 
|Enum type | Pascal Casing| | 
|Events | Pascal Casing| | 
|Exception class | Pascal Casing | End with `Exception`| 
|public Fields | Pascal Casing| | 
|Methods | Pascal Casing| | 
|Namespace | Pascal Casing| | 
|Property | Pascal Casing | | 
|Protected/private Fields | Camel Casing | |  
|Parameters | Camel Casing | | 

## Programming Practices ##
### Visibility ###
Do not make any instance or class variable `public`, make them `private`. For private members prefer not using “`private`” as modifier just do write nothing. Private is the default case and every C ♯ programmer should be aware of it.

Use properties instead. You may use `public static` fields (or `const`) as an exception to this rule, but it should not be the rule.

### No 'Magic' Numbers ###
Don’t use magic numbers, i.e. place constant numerical values directly into the source code. Replacing these later on in case of changes (say, your application can now handle 3540 users instead of the 427 hard coded into your code in 50 lines scattered throughout your 25000 LOC) is error-prone and unproductive. Instead declare a `const` variable which contains the number :

```c#
public class MyMath
{
	public const double PI = 3.14159...
}
```

## Code Examples ##
### Brace Placement Example ###

```c#
namespace ShowMeTheBracket
{
	public enum Test {
		TestMe,
		TestYou
	}

	public class TestMeClass
	{
		Test test;
		public Test Test {
			get {
				return test;
			}
			set {
				test = value;
			}
		}

		void DoSomething( )
		{
			if ( test == Test.TestMe ) {
				//...stuff gets done
			} else {
				//...other stuff gets done
			}
		}
	}
}
```

Brackets should begin on a new line only after:

- Namespace declarations
- Class/Interface/Struct declarations
- Method declarations

### Variable Naming Example ###
instead of :

```c#
for ( int i = 1; i < num; ++i ) {
	meetsCriteria[i] = true;
}

for ( int i = 2; i < num / 2; ++i ) {
	int j = i + i;
	while ( j <= num ) {
		meetsCriteria[j] = false;
		j += i;
	}
}

for ( int i = 0; i < num; ++i ) {
	if ( meetsCriteria[i] ) {
		Console.WriteLine( i + " meets criteria" );
	}
}
```

try intelligent naming :

```c#
for ( int primeCandidate = 1; primeCandidate < num; ++primeCandidate )
	{
		isPrime[primeCandidate] = true;
	}

for ( int factor = 2; factor < num / 2; ++factor ) {
	int factorableNumber = factor + factor;
	while ( factorableNumber <= num ) {
		isPrime[factorableNumber] = false;
		factorableNumber += factor;
	}
}


for ( int primeCandidate = 0; primeCandidate < num; ++primeCandidate )
{
	if ( isPrime[primeCandidate] ) {
		Console.WriteLine( primeCandidate + " is prime." );
	}
}
```

Note: Indexer variables generally should be called `i`, `j`, `k` etc. But in cases like this, it may make sense to reconsider this rule.  In general, when the same counters or indexers are reused, give them meaningful names.