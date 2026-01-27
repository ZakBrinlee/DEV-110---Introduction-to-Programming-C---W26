# Week 3 Lab - Temperature Converter

## 🎯 Learning Objectives

In this hands-on lab, you'll practice:

1. **Data Types**: `string`, `bool`, `int`, `double`
2. **User Input**: Using `Console.ReadLine()`
3. **Type Conversion**: `double.Parse()` for numeric input
4. **Arithmetic Operations**: Multiplication, division, addition, subtraction
5. **String Formatting**: Using `:F2` for decimal places
6. **Conditional Logic**: `if/else` statements
7. **Boolean Expressions**: Converting user choices to `bool`

## 📚 What You'll Build

Follow along with your instructor to build a temperature converter that:

- Converts between Celsius and Fahrenheit
- Shows the conversion formula (optional)
- Displays interesting temperature facts
- Uses all four main data types from Week 2-3

## 🚀 Getting Started

### Step 1: Navigate to the Project

```bash
cd labs/week-3-variables-data-modeling/TemperatureConverter/starter
```

### Step 2: Open Program.cs

Open the `Program.cs` file and you'll see TODO comments guiding you through each step.

### Step 3: Follow Along with Your Instructor

Your instructor will walk through each section. Write the code as you go!

## 📝 Variable Names to Use

As you complete the lab, use these specific variable names:

- `userName` - Store the user's name (string)
- `showDetails` - Whether to show detailed calculations (bool)
- `inputTemp` - The temperature value entered by user (double)
- `conversionChoice` - Which unit the input is in (string)
- `convertedTemp` - The calculated result (double)
- `conversionCount` - Number of conversions performed (int)

## 🧪 Temperature Conversion Formulas

### Celsius to Fahrenheit

```
F = (C × 9/5) + 32
```

**Important**: Use `9.0` and `5.0` (not `9` and `5`) to ensure decimal division!

```csharp
double convertedTemp = (inputTemp * 9.0 / 5.0) + 32.0;
```

### Fahrenheit to Celsius

```
C = (F - 32) × 5/9
```

```csharp
double convertedTemp = (inputTemp - 32.0) * 5.0 / 9.0;
```

## 🎮 Test Your Program

After completing each section, test your program:

```bash
dotnet run
```

### Sample Test Cases

**Test 1: Celsius to Fahrenheit**

```
Enter your name: Alice
Show detailed calculations? yes
Enter a temperature value: 25
Is this temperature in (C)elsius or (F)ahrenheit? C
```

Expected: 77°F

**Test 2: Fahrenheit to Celsius**

```
Enter your name: Bob
Show detailed calculations? no
Enter a temperature value: 32
Is this temperature in (C)elsius or (F)ahrenheit? F
```

Expected: 0°C

**Test 3: Interesting Temperatures**

- Try **100°C** (should show "Above boiling")
- Try **0°C** (should show freezing point differences)
- Try **-40** (this is the same in both C and F!)

## 🔑 Key Concepts

### 1. Data Type Selection

```csharp
string userName;        // Text - names, words, letters
bool showDetails;       // True/False - yes/no questions
int conversionCount;    // Whole numbers - counting
double inputTemp;       // Decimal numbers - measurements
```

**Why double for temperature?**
Temperatures can have decimal values (98.6°F, 36.5°C), so we need `double`, not `int`.

### 2. Integer vs Decimal Division

```csharp
// ❌ WRONG - Integer division
double result = inputTemp * 9 / 5;  // 9/5 = 1 (not 1.8!)

// ✅ CORRECT - Decimal division
double result = inputTemp * 9.0 / 5.0;  // 9.0/5.0 = 1.8
```

Always include `.0` when you need precise division!

### 3. Boolean Logic

```csharp
// Convert user text input to boolean
bool showDetails = choice == "yes" || choice == "y";
//                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
//                 This expression evaluates to true or false
```

The `||` operator means "OR" - true if either condition is true.

### 4. String Methods

```csharp
string input = Console.ReadLine();
string upper = input.ToUpper();    // "celsius" → "CELSIUS"
string lower = input.ToLower();    // "YES" → "yes"
```

These make comparisons case-insensitive!

### 5. Format Specifiers

```csharp
double temp = 25.6789;

Console.WriteLine($"{temp:F2}");  // Output: 25.68 (2 decimals)
Console.WriteLine($"{temp:F0}");  // Output: 26 (no decimals)
Console.WriteLine($"{temp}");     // Output: 25.6789 (all decimals)
```

`:F2` is perfect for temperatures - 2 decimal places is standard.

## 🐛 Common Issues & Solutions

### Issue: "Input string was not in a correct format"

**Cause**: Trying to parse non-numeric input

```csharp
// ❌ User types "twenty-five"
double temp = double.Parse("twenty-five");  // ERROR!

// ✅ User must type "25" or "25.5"
double temp = double.Parse("25.5");  // Works!
```

**Solution**: Make sure to enter actual numbers when prompted.

### Issue: Wrong Conversion Result

**Cause**: Using integer division

```csharp
// ❌ This gives wrong answer
double f = inputTemp * 9 / 5 + 32;  // 9/5 evaluates to 1

// ✅ This is correct
double f = inputTemp * 9.0 / 5.0 + 32.0;  // 9.0/5.0 = 1.8
```

**Solution**: Always use `.0` for decimal numbers in formulas!

### Issue: Boolean Always False

**Cause**: Case sensitivity

```csharp
// ❌ Won't work if user types "Yes" or "YES"
bool show = input == "yes";

// ✅ Convert to lowercase first
bool show = input.ToLower() == "yes";
```

**Solution**: Use `.ToLower()` or `.ToUpper()` before comparing.

## 📋 Code-Along Checklist

As you complete the lab, check off each section:

- [ ] Display welcome message
- [ ] Get user's name (string)
- [ ] Greet user
- [ ] Ask about detailed output (bool)
- [ ] Get temperature value (double)
- [ ] Get unit choice (string)
- [ ] Initialize conversion counter (int)
- [ ] Implement Celsius to Fahrenheit conversion
- [ ] Implement Fahrenheit to Celsius conversion
- [ ] Handle invalid unit input
- [ ] Display temperature analysis
- [ ] Show water state (ice/liquid/steam)
- [ ] Display conversion count
- [ ] Test with multiple values

## 🎯 Connection to Calculator Lite

Notice the patterns you're practicing:

| Temperature Converter | Calculator Lite Assignment       |
| --------------------- | -------------------------------- |
| userName (string)     | userName (string)                |
| showDetails (bool)    | useDecimals (bool)               |
| inputTemp (double)    | number1, number2 (double)        |
| conversionCount (int) | calculationCount (int)           |
| Temperature formulas  | Math operations (+, -, \*, /, %) |
| if/else for unit      | if/else for division by zero     |

These are the **exact same skills** you'll need for the assignment!

## 💡 After the Lab

Once you've completed this code-along:

1. **Review your code** - Can you explain each line?
2. **Experiment** - Try different temperatures, test edge cases
3. **Compare** - Look at the solution in `solution/` folder
4. **Apply** - Use these patterns in Calculator Lite assignment

## 🏆 Challenge: Extend Your Program

If you finish early, try adding:

1. **Kelvin conversion**

    ```csharp
    // Celsius to Kelvin: K = C + 273.15
    // Kelvin to Celsius: C = K - 273.15
    ```

2. **Input validation**
    - Check if temperature is below absolute zero
    - Absolute zero: -273.15°C or -459.67°F

3. **Temperature descriptions**
    ```csharp
    if (celsius < 0)
        Console.WriteLine("Status: Freezing cold!");
    else if (celsius < 15)
        Console.WriteLine("Status: Cold");
    else if (celsius < 25)
        Console.WriteLine("Status: Comfortable");
    else
        Console.WriteLine("Status: Hot!");
    ```

## 📚 Reference

### Complete Formula Reference

```csharp
// Celsius to Fahrenheit
double fahrenheit = (celsius * 9.0 / 5.0) + 32.0;

// Fahrenheit to Celsius
double celsius = (fahrenheit - 32.0) * 5.0 / 9.0;

// Water phase changes
// Freezing: 0°C = 32°F
// Boiling: 100°C = 212°F
```

### Operator Precedence

```
1. Parentheses: ()
2. Multiplication & Division: * /
3. Addition & Subtraction: + -
```

Example: `(25 * 9.0 / 5.0) + 32.0`

1. Parentheses first: `25 * 9.0 / 5.0` = `45.0`
2. Then addition: `45.0 + 32.0` = `77.0`

---

**Need Help?**

- Check the TODO comments in Program.cs
- Ask your instructor
- Look at the solution in `solution/` folder (but try yourself first!)

**Ready for More?**
Once you complete this lab, you'll be well-prepared for the Calculator Lite assignment!
