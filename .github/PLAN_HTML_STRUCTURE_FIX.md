# Plan: Update GitHub Copilot Instructions to Require Valid HTML5 Structure

**Date:** February 22, 2026
**Issue:** Lab CANVAS_LAB_PAGE.html files were created without proper HTML5 structure (missing DOCTYPE, html, head, body tags)
**Impact:** Weeks 4-6 labs have incomplete HTML fragments; Weeks 7-8 have been corrected and now serve as reference templates

---

## Root Cause Analysis

### Current State

The `lab-canvas-page.instructions.md` file references templates that lack proper HTML structure:

- `labs/week-4-decisions/solution/CANVAS_LAB_PAGE.html` - HTML fragment only (no DOCTYPE, head, body)
- `labs/week-5-loops/solution/CANVAS_LAB_PAGE.html` - HTML fragment only (no DOCTYPE, head, body)

**However:**

- `labs/week-7-arrays/solution/CANVAS_LAB_PAGE.html` - ✅ Has proper HTML5 structure
- `labs/week-8-classes-debugging/solution/CANVAS_LAB_PAGE.html` - ✅ Has proper HTML5 structure with CSS

**Problem:** The instruction file says "mirror the structure" of templates that are incomplete (Week 4-5), when we should be referencing the complete templates (Week 7-8).

### Comparison to Module Assignment Pages

The `module-canvas-assignment.instructions.md` doesn't explicitly require HTML5 structure either, BUT:

- The reference template (`modules/week-05-guess-the-number/solution/CANVAS_ASSIGNMENT.html`) HAS complete HTML5 structure
- This means the "mirror the structure" instruction works correctly for modules

---

## Proposed Solution

### Phase 1: Update Instruction Files (Immediate)

#### 1.1 Update `lab-canvas-page.instructions.md`

**File:** `.github/instructions/lab-canvas-page.instructions.md`

**Current content:**

```
---
applyTo: "labs/**/solution/CANVAS_LAP_PAGE.html"
---

- Mirror the structure, formatting, and tone of:
    - labs/week-4-decisions/solution/CANVAS_LAB_PAGE.html
    - labs/week-5-loops/solution/CANVAS_LAB_PAGE.html
- Keep the same section order (table header, Objective, What You're Building, Setup, Follow-Along Steps, Test Your Program, Lab Expectations).
- Replace only the lab name, links, and step content to match the current lab.
- Leave Zoom/Panopto links blank if not provided.
```

**Proposed new content:**

````
---
applyTo: "labs/**/solution/CANVAS_LAB_PAGE.html"
---

# Lab Canvas Page Requirements

## HTML Structure (REQUIRED)
- **MUST be a complete, valid HTML5 document**
- Required structure:
  ```html
  <!DOCTYPE html>
  <html lang="en">
  <head>
      <meta charset="UTF-8">
      <meta name="viewport" content="width=device-width, initial-scale=1.0">
      <title>Week X Lab: [Lab Name] - Canvas Lab Page</title>
      <style>
          /* CSS styles here */
      </style>
  </head>
  <body>
      <!-- Lab content here -->
  </body>
  </html>
````

## CSS Styles (REQUIRED)

Include these base styles in the `<head>`:

- `body`: font-family (Arial), max-width (900px), margin (0 auto), padding (20px), line-height (1.6)
- `.alert-info`: background (#d9edf7), border, padding, border-radius for info boxes
- `code`: background (#f4f4f4), padding, border-radius, monospace font
- `table`: width (100%), margin, border-collapse
- `th, td`: padding, text-align, border
- `kbd`: background (#333), color (#fff), padding for keyboard shortcuts

## Content Structure

Mirror the content organization from these reference templates:

- `labs/week-7-arrays/solution/CANVAS_LAB_PAGE.html`
- `labs/week-8-classes-debugging/solution/CANVAS_LAB_PAGE.html`

Section order:

1. **Page title** (h1) - may include emoji
2. **Video/Links Table** - Lecture videos, Zoom, Panopto, GitHub repo link
3. **Objective Section** (h2 or h3) - Learning goals as bulleted list
4. **What You're Building** (h2) - Numbered list of deliverables
5. **Setup** (h2) - Steps to navigate and run project
6. **Follow-Along Steps** (h2) - Detailed sections (h3) for each part
7. **Test Your Program** (h2) - Verification checklist
8. **Lab Expectations** (h2) - Success criteria
9. **Key Concepts** (h2) - Bulleted summary (optional, if applicable)
10. **Submission** (h2) - Submission instructions (optional)
11. **Need Help?** (h2) - Resources for students (optional)

## Important Notes

- Canvas accepts full HTML documents (it will extract and render the body content)
- Valid HTML ensures proper rendering and accessibility
- Include closing `</body>` and `</html>` tags
- Use semantic HTML5 elements
- Leave Zoom/Panopto links empty (`href=""`) if not yet available
- Reference Week 7 or Week 8 labs as templates (both have proper structure)
- DO NOT reference Week 4-6 labs as templates (they lack proper HTML structure)

```

#### 1.2 Update `module-canvas-assignment.instructions.md`
**File:** `.github/instructions/module-canvas-assignment.instructions.md`

**Add explicit HTML5 requirement at the top:**
```

---

## applyTo: "modules/\*\*/solution/CANVAS_ASSIGNMENT.html"

# Module Canvas Assignment Requirements

## HTML Structure (REQUIRED)

- **MUST be a complete, valid HTML5 document**
- Include: `<!DOCTYPE html>`, `<html lang="en">`, `<head>`, `<body>`, closing tags
- Reference: `modules/week-08-mad-libs/solution/CANVAS_ASSIGNMENT.html` for complete structure

## Content Requirements

- Mirror the structure, formatting, and tone of modules/week-05-guess-the-number/solution/CANVAS_ASSIGNMENT.html.
- Keep the same overall section order and headings.
- Remove the "Tips for Success" and "Common Issues and Solutions" sections unless explicitly requested.
- Place the Git Workflow section immediately after Prerequisites.
- Place the "What to Submit on Canvas" section immediately after the Git Workflow section.
- Update only the week number, assignment name, points, due date, prompts, and rubric to match the current module.

````

---

### Phase 2: Update Main Copilot Instructions (Context)

**File:** `.github/copilot-instructions.md`

**Add a new section after "Labs: Universal workflow rules":**

```markdown
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
````

---

## Implementation Order

### Priority 1 (Complete - Done During This Session)

✅ Fix `labs/week-8-classes-debugging/solution/CANVAS_LAB_PAGE.html`
✅ Add CSS styles to `labs/week-7-arrays/solution/CANVAS_LAB_PAGE.html`

### Priority 2 (Next - Update Instructions)

1. Update `.github/instructions/lab-canvas-page.instructions.md` with explicit HTML5 requirements
2. Update `.github/instructions/module-canvas-assignment.instructions.md` to add HTML5 requirement
3. Update `.github/copilot-instructions.md` to add HTML files section

### Priority 3 (Optional - User Decision)

Optionally update older lab HTML files (weeks 4-6) to have proper structure, but this is NOT required.
The instruction files will reference Week 7-8 as templates, so new labs will be created correctly.

---

## Benefits of This Approach

1. **Prevents future issues** - New Canvas pages will automatically be created with proper structure
2. **Clear documentation** - Explicit requirements in instruction files
3. **Consistency** - All new HTML files follow same pattern
4. **Accessibility** - Valid HTML5 ensures better accessibility
5. **Maintainability** - Easier to update and modify structured HTML
6. **No backfill required** - Week 7 and 8 already correct; old labs (4-6) can remain as-is

---

## Testing Criteria

After implementing these changes, verify:

- [ ] New lab HTML files include `<!DOCTYPE html>`
- [ ] New lab HTML files include complete `<head>` with `<title>` and `<style>`
- [ ] New lab HTML files include complete `<body>` with all content
- [ ] New lab HTML files include closing `</body>` and `</html>` tags
- [ ] CSS styles are properly scoped within `<style>` tags
- [ ] Content is properly nested within semantic HTML5 elements

---

## Files to Modify

### Instructions (Priority 2 - Next Steps)

1. `.github/instructions/lab-canvas-page.instructions.md`
2. `.github/instructions/module-canvas-assignment.instructions.md`
3. `.github/copilot-instructions.md`

### Already Corrected (Priority 1 - Complete)

4. `labs/week-7-arrays/solution/CANVAS_LAB_PAGE.html` ✅
5. `labs/week-8-classes-debugging/solution/CANVAS_LAB_PAGE.html` ✅

### Not Required (Old Labs - Optional)

- `labs/week-4-decisions/solution/CANVAS_LAB_PAGE.html` - Can remain as-is
- `labs/week-5-loops/solution/CANVAS_LAB_PAGE.html` - Can remain as-is
- `labs/week-6-strings-menus/solution/CANVAS_LAB_PAGE.html` - Can remain as-is

---

## Notes

- This issue existed because the instruction file referenced incomplete templates (Week 4-5)
- Week 7 and Week 8 labs already have proper HTML5 structure
- The module assignment pages worked correctly because their template WAS complete
- Canvas accepts full HTML documents, so this is the proper approach
- **No need to backfill Week 4-6 labs** - they can remain as-is; new labs will reference Week 7-8 as templates
- Week 7 and 8 now serve as the correct reference templates for all future lab Canvas pages
