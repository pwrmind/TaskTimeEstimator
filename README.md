# Task Time Estimator ⏱️

![Console Application](https://img.shields.io/badge/Type-Console_Application-blue)
![.NET 6](https://img.shields.io/badge/.NET-6-green)

A simple yet powerful console application for estimating task completion time using probability theory and fractal analysis principles.

## Key Features ✨

- **Probability-based estimation** 📊 - Uses the formula `T = (Total Base Time) / (u^x) * F`
- **Visual calculation breakdown** 👁️ - Shows each step of the estimation process
- **Intuitive interface** 💻 - Emoji-enhanced prompts and clear instructions
- **Flexible input** 🔧 - Add unlimited tasks with custom time estimates
- **Realistic modeling** 🌍 - Incorporates fractal coefficient for system complexity

## How It Works 🧠

The application calculates time estimates using this formula:

```
Final Estimate = (Σ Base Time) / (u^x) * F
```

Where:
- **Σ Base Time** = Sum of all tasks' base time estimates
- **u** = Probability of accurate estimation for a single task
- **x** = Number of tasks
- **F** = Global fractal coefficient (system complexity factor)

## Getting Started 🚀

### Prerequisites
- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)

### Installation
```bash
git clone https://github.com/yourusername/task-time-estimator.git
cd task-time-estimator
dotnet run
```

## Usage Example 📝

```text
⏱️  Task completion time estimation with probability analysis
--------------------------------------------------------

🔮 Enter probability of accurate estimation for a single task (0.1-0.99): 0.8

🌍 Enter global fractal coefficient (1.0-2.5): 1.5

📝 Enter task name (ENTER to finish): Research
⏳ Base time estimate: 20

📝 Enter task name (ENTER to finish): Development
⏳ Base time estimate: 50

📝 Enter task name (ENTER to finish): Testing
⏳ Base time estimate: 30

✨ Results:
-------------------------------------
| Task         | Base Time |
-------------------------------------
| Research     |      20.0 |
| Development  |      50.0 |
| Testing      |      30.0 |
-------------------------------------

📊 Probability analysis:
Single task accuracy probability (u): 0.80
Number of tasks (x): 3
All tasks accuracy probability (u^x): 0.5120

🧮 Final calculation:
Total base time: 100.0
Fractal coefficient: 1.5

🚀 FINAL ESTIMATE: 293.0
📌 Formula: T = (100.0) / (0.5120) * 1.5
```

## Key Concepts 📚

### Probability of Accurate Estimation (u)
- Represents confidence in single task estimates
- Range: 0.1 (low confidence) to 0.99 (high confidence)
- Typical values: 0.7-0.9 for experienced teams

### Fractal Coefficient (F)
- Accounts for system complexity and unforeseen factors
- Range: 1.0 (simple) to 2.5 (highly complex)
- Based on project novelty, team experience, and requirements stability

### The Formula Explained
`T = (Total Base Time) / (u^x) * F` accounts for:
1. Probability that all estimates are accurate (u^x)
2. System complexity through the fractal coefficient (F)
3. Combined effect of multiple tasks (x)

## Contributing 🤝

Contributions are welcome! Please follow these steps:
1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a pull request

## License 📄

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---
**Estimate wisely, deliver successfully!** 🚀