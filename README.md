# LapTracker (Project/Stage Name)
A C# console application that reads weekly lap times of an amateur athlete and determines whether their total running time has been continuously improving week over week.

# Track Running Improvement Checker(Project Design)

A C# console application that analyses an amateur athlete's weekly lap times
and determines whether their total running time has been continuously decreasing
(i.e. continuously improving) across all measured weeks.

---

## How It Works

The program reads the number of weeks and laps per week, sums up the lap times
for each week, then checks if each week's total is strictly less than the previous.
If every week is faster than the last, it outputs `true`, otherwise `false`.

---

## Input Format
n m
t1 t2 ... tm ← week 1 lap times
t1 t2 ... tm ← week 2 lap times


- `n` — number of weeks (2 ≤ n ≤ 10)
- `m` — number of laps per week (1 ≤ m ≤ 10)
- `t` — individual lap time in seconds (30 ≤ t ≤ 60)

---

## Output Format

A single `true` or `false` on standard output.

---

## Examples

**Example 1**
Input: Output:
4 4 false
51 52 53 59
52 52 51 55
51 54 56 59
50 51 49 53

Week totals: 215 → 210 → 220 → 203 — not continuously decreasing → `false`

**Example 2**
Input: Output:
3 3 true
50 49 51
49 49 50
50 46 48

Week totals: 150 → 148 → 144 — continuously decreasing → `true`

---

## Project Structure
cpp/
├── Program.cs # Main logic — input parsing and improvement check
├── CP2.csproj # .NET project file
└── CP2.sln # Solution file


---

## Built With

- C# / .NET 10
- Standard console I/O



