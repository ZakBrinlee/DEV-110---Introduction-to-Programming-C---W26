# GitHub Copilot Instructions — DEV 110 Course Repository

You are assisting with a college intro C# course repository. Prioritize clarity, consistency, and beginner-friendly materials.

Follow the scoped instruction files in .github/instructions/ when working in their target paths.

## How to interact with me

When I ask you to do something:

- **Clearly reiterate** what I'm asking for in your own words before starting work
- Be **personable and conversational** in your responses
- After completing work, provide a **clear summary** that includes:
    - What you completed
    - How you accomplished it (key decisions, approaches taken)
    - All files you created, modified, or referenced
    - Any important notes or next steps

## Labs: Universal workflow rules

When creating or refactoring labs:

1. **Reference template**: Use `labs/week-6-strings-menus/` as the primary template for structure, tone, and file organization
2. **Solution-first approach**: Always create and complete the `/solution` folder first (including Program.cs, INSTRUCTOR_NOTES.md, CANVAS_LAB_PAGE.html) before moving to starter code or other lab components
3. **Starter follows instructor notes**: The `/starter/Program.cs` TODOs must directly follow the step-by-step flow documented in `solution/INSTRUCTOR_NOTES.md`

Labs must follow the lab-specific instruction files in .github/instructions/.

## HTML Files: Canvas Pages

When creating or updating HTML files for Canvas (CANVAS_LAB_PAGE.html, CANVAS_ASSIGNMENT.html):

1. **Always create complete, valid HTML5 documents**
    - Include `<!DOCTYPE html>`
    - Include `<html lang="en">`, `<head>`, and `<body>` tags
    - Always close with `</body>` and `</html>`

2. **Use the corrected templates as reference**
    - Labs: `labs/week-7-arrays/solution/CANVAS_LAB_PAGE.html` or `labs/week-8-classes-debugging/solution/CANVAS_LAB_PAGE.html`
    - Modules: `modules/week-08-mad-libs/solution/CANVAS_ASSIGNMENT.html`

3. **Do NOT reference Week 4-6 lab HTML files** - they are incomplete fragments (no DOCTYPE, head, or body tags)

4. **Include proper CSS styling in the `<head>`** section for consistent formatting

Canvas accepts full HTML documents and will properly render them.

## Golden rule: Follow existing templates

- The first 3 teaching modules already exist and are the source of truth for structure and formatting.
- When creating or updating course material, first inspect existing modules and mirror their style, naming, headings, and tone.
- Do not invent new folder layouts or new documentation formats unless explicitly requested.

## Reference modules (source of truth)

When you need a template, copy patterns from these modules in order:

1. modules/week-02-calculator-lite/
2. modules/week-03-profile-card/
3. modules/week-05-guess-the-number/

## Repository structure expectations (modules)

Each teaching module must follow this structure:

/<module-root>/
README.md # Student-facing assignment overview (what/why/how, requirements, submission)
/solution/

README.md # Instructor breakdown (approach, key concepts, pitfalls, grading notes)
(completed working solution files)
/starter/

README.md # Student instructions for starting point + how to run + what to change
Program.cs # Starter code with most logic removed + detailed TODOs
STUDY_NOTES.md # Student reflection: what they learned, what was hard, how they solved it

/tests/ # Use /tests/ (plural) in this repo
(test project/files that validate the starter assignment)

## README.md (student-facing) requirements

For each module README.md:

- Use the same heading structure as earlier modules.
- Required heading order:
    1. Summary
    2. Learning Objectives
    3. Resources (if used in the module)
    4. Assignment Requirements
    5. Example Output (if applicable)
    6. Getting Started
    7. Grading Criteria
    8. Helpful Tips / Common Pitfalls
    9. Submission
- Keep language beginner-friendly and direct.
- Ensure there is only one “Grading Criteria” section (avoid duplicate headings).

## Starter code expectations (Program.cs)

- Program.cs must compile and run.
- Remove the majority of core logic so students must implement it.
- Leave clear, numbered TODOs (very explicit):
    - Use a format like: `// TODO 1: ...`
    - Include hints about variable names/types where helpful, but do not provide the full solution.
- Include “print checkpoints” (suggested Console.WriteLine output) so students can verify progress.
- Keep starter code minimal and readable; avoid advanced C# features not yet taught.

## STUDY_NOTES.md expectations

Students should be prompted to write short reflections:

- What I built (1–3 sentences)
- What I learned (bullets)
- What was confusing / how I overcame it
- What I would improve next time
  Keep it short and structured.
- Use modules/week-05-guess-the-number/starter/STUDY_NOTES.md as a STRUCTURE template, but tailor headings and prompt text to the specific module assignment.

## Solution folder expectations

- Provide a complete, correct solution that matches the assignment requirements.
- Include an instructor README.md with:
    - High-level approach
    - Key concepts reinforced
    - Where students commonly struggle
    - Notes about testing/grading
- Avoid changing solution conventions used in earlier modules.

## Tests expectations

- Tests must validate the starter assignment requirements.
- Follow the existing test framework and patterns already used in the repo (do not introduce a new framework).
- Tests should be deterministic and runnable via the repo’s existing GitHub Actions workflow.
- Do not modify CI workflows unless explicitly requested.

## Do not change (unless explicitly asked)

- GitHub Actions workflows
- Solution and project naming conventions
- Existing test framework or runner
- Established folder layout under modules/

## GitHub workflow expectations

- Students must push code to THEIR OWN repositories.
- Students must work on the branch naming pattern used by the course (example: `assignment/week-02`).
- PRs should be created in the student’s repo (not the instructor repo).
- In README “Submission” sections, include steps: create the branch, commit/push, open a PR.

## Output and style guidance for generated content

When you generate new module materials:

- Prefer structured Markdown with clear headings.
- Use consistent terminology across modules.
- Keep examples simple and aligned with what students have learned so far.
- If unsure about a convention, copy the closest existing module’s pattern rather than guessing.
- Match any existing prompt strings and output formatting used in tests; do not change wording, casing, or punctuation unless explicitly requested.

## Language level and feature constraints

- Avoid advanced C# features not yet taught.
- Prefer explicit types over `var` unless the module explicitly introduces it.
- Avoid LINQ, async/await, and collections beyond arrays/lists until a module explicitly introduces them.

## If instructions conflict

If there is any ambiguity:

- Prefer consistency with the existing modules and repository patterns.
- Ask for or infer details by inspecting existing module files first.
