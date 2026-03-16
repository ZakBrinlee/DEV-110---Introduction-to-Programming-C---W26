# Week 11 Lab — Flashcard Quiz App

## Overview

This is a live lecture/demo session. There is no starter code, I will be building the
entire app from scratch, explaining every decision along the way.

This app serves as a **complete, real-world example** of how to use all eight core C# concepts
from the course in a single cohesive project, the same eight concepts required for the
**CREATE YOUR own app - Final Project (Extra Credit)**.

---

## What This App Does

- Loads flashcards from a CSV file (or uses seed data on first run)
- Lets the user add new cards, view all cards, and take a quiz
- Tracks a score and shows a summary after each quiz
- Saves the card deck back to `flashcards.csv` so data persists

---

## Final Project Concepts Demonstrated

| #   | Concept                          | Where it appears                                            |
| --- | -------------------------------- | ----------------------------------------------------------- |
| 1   | Variables with appropriate types | `string`, `int`, `double`, `bool` throughout                |
| 2   | If/else decisions                | Empty-list guards, `File.Exists` branch, score feedback     |
| 3   | Loop                             | Menu `while` loop + quiz `for` loop                         |
| 4   | Formatted string output          | `PadRight` card table, `{percent:F0}%` quiz summary         |
| 5   | `List<T>`                        | `List<Flashcard>` — the card deck                           |
| 6   | Custom class                     | `Flashcard.cs` — `Question`, `Answer`, `ToCSV()`, `Parse()` |
| 7   | Named methods                    | 7 methods beyond `Main`                                     |
| 8   | File I/O                         | `LoadCards()` reads CSV, `SaveCards()` writes CSV           |

---

## Getting started

```bash
cd labs/week-11-demo-app
```
