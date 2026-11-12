
# My Pizza Order Form (C# Windows Forms)

A small desktop app built with C# and Windows Forms where the user designs a pizza and sees the order summary and the total price update live. It is a practice project for working with common Windows Forms controls and their events.

## Features

- Choose a **size**, **toppings**, a **crust type**, and **where to eat**.
- The **Order Summary** panel on the right updates every time an option changes: size, toppings, crust, where to eat, and the total price.
- The total price is calculated automatically from the selected options.
- **Order Pizza** asks for confirmation, shows a success message, and locks the form so the order can no longer be changed.
- **Reset Form** asks for confirmation and unlocks the form again.

## Menu and Prices

| Group | Option | Price |
|---|---|---|
| Size | Small | $10 |
| Size | Medium | $20 |
| Size | Large | $30 |
| Toppings | Extra Cheese | $10 |
| Toppings | Mushrooms | $10 |
| Toppings | Tomatoes | $5 |
| Toppings | Onion | $5 |
| Toppings | Olives | $5 |
| Toppings | Green Peppers | $5 |
| Crust | Thin | $0 |
| Crust | Thick | $10 |
| Where To Eat | Eat In / Take Out | free |

**Total price = size + sum of selected toppings + crust.**
For example, a Medium pizza ($20) with Extra Cheese ($10), Olives ($5), and a Thick crust ($10) costs $45.

## How It Works

- Each price is stored in the `Tag` property of its radio button or checkbox in the Designer. The code reads it with `Convert.ToSingle(...Tag)`, so changing a price does not need any code change.
- Every radio button and checkbox has a `CheckedChanged` event that recalculates the total and refreshes the matching label in the summary panel.
- Radio buttons are grouped inside `GroupBox` controls, so each group allows only one choice, while toppings are checkboxes that allow several.
- `Order Pizza` and `Reset Form` use `MessageBox` for confirmation and enable or disable the four group boxes.

## Project Structure

```
WindowsFormsApp2.slnx
WindowsFormsApp2.csproj
Program.cs                  # Entry point: runs the Pizza_Order form
Pizza Order.cs              # Form logic: price calculation, event handlers
Pizza Order.Designer.cs     # Designer-generated UI layout
App.config
Properties/                 # Assembly info, resources, and settings
```

## Technologies

- C#
- .NET Framework 4.7.2
- Windows Forms

## Concepts Practiced

- Windows Forms controls: `RadioButton`, `CheckBox`, `GroupBox`, `Label`, `Panel`, `Button`.
- Event handling (`CheckedChanged`, `Click`).
- Using the `Tag` property to attach data to controls.
- Dialogs with `MessageBox`.
- Splitting code into small methods (`GetSelectedSizePrice`, `CalculateToppingsPrice`, `GetCrustPrice`, `CalculatePrice`).

## Author

[abdrhmnKH](https://github.com/abdrhmnKH)
