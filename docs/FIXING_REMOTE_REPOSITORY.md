# Fixing Your Remote Repository Configuration

## The Problem

If you accidentally cloned the instructor's repository instead of your own fork, you might be trying to push to the wrong place. This guide will help you fix that!

---

## Step 1: Check Your Current Configuration

First, let's see where your local repository is currently pointing:

```bash
git remote -v
```

**What you'll see and what it means:**

### ❌ **WRONG Configuration** (pointing to instructor's repo):

```
origin  https://github.com/ZakBrinlee/DEV-110-...-W26.git (fetch)
origin  https://github.com/ZakBrinlee/DEV-110-...-W26.git (push)
```

If you see `ZakBrinlee` (or the instructor's username), you're pushing to the wrong repository!

### ✅ **CORRECT Configuration** (pointing to your fork):

```
origin  https://github.com/YOUR-USERNAME/DEV-110-...-W26.git (fetch)
origin  https://github.com/YOUR-USERNAME/DEV-110-...-W26.git (push)
```

You should see **your own GitHub username**, not the instructor's.

---

## Step 2: Find Your Fork's URL

1. Go to **GitHub.com** and log in
2. Click on **your profile icon** (top right) → **Your repositories**
3. Find your forked copy of the DEV 110 repository
4. Click the green **Code** button
5. Copy the **HTTPS URL** (it should look like: `https://github.com/YOUR-USERNAME/DEV-110-...-W26.git`)

**Write down or copy this URL** - you'll need it in the next step!

---

## Step 3: Fix Your Remote Configuration

Now we'll update your local repository to point to your fork instead of the instructor's repository.

### Change the Origin Remote

Run this command, replacing `YOUR-URL-HERE` with the URL you copied in Step 2:

```bash
git remote set-url origin YOUR-URL-HERE
```

**Example:**

```bash
git remote set-url origin https://github.com/ZakBrinlee/DEV-110---Introduction-to-Programming-C---W26.git
```

### Add Upstream Remote (Optional but Recommended)

The "upstream" remote lets you get updates from the instructor's repository when new assignments are posted:

```bash
git remote add upstream https://github.com/ZakBrinlee/DEV-110---Introduction-to-Programming-C---W26.git
```

**Note:** If you get an error saying "remote upstream already exists", you can skip this step or update it:

```bash
git remote set-url upstream https://github.com/ZakBrinlee/DEV-110---Introduction-to-Programming-C---W26.git
```

---

## Step 4: Verify Your Configuration

Check that everything is now set up correctly:

```bash
git remote -v
```

**You should see:**

```
origin    https://github.com/YOUR-USERNAME/DEV-110-...-W26.git (fetch)
origin    https://github.com/YOUR-USERNAME/DEV-110-...-W26.git (push)
upstream  https://github.com/ZakBrinlee/DEV-110-...-W26.git (fetch)
upstream  https://github.com/ZakBrinlee/DEV-110-...-W26.git (push)
```

✅ **origin** = Your fork (where you push your work)
✅ **upstream** = Instructor's repo (where you get updates)

---

## Step 5: Push Your Work

Now you can push your code to your own repository:

```bash
# Make sure you're on the correct branch
git branch

# Push to your fork
git push origin <branch-name>
```

**Example:**

```bash
git push origin assignment/week-01
```

---

## Common Questions

### Q: What if I already pushed to the instructor's repository?

**A:** Don't worry! The instructor's repository is likely protected, so your push was probably rejected. Just follow the steps above to fix your configuration and push again.

### Q: What if I get "Permission denied" errors?

**A:** This is actually good news - it means you're trying to push to a repository you don't have access to. Follow the steps above to point to your fork instead.

### Q: How do I get updates from the instructor?

**A:** If you set up the upstream remote (Step 3), you can get updates like this:

```bash
# Make sure you're on main branch and have no uncommitted changes
git checkout main
git fetch upstream
git merge upstream/main
```

### Q: What if I don't have a fork?

**A:** You need to create one first!

1. Go to the instructor's repository: `https://github.com/ZakBrinlee/DEV-110---Introduction-to-Programming-C---W26`
2. Click the **Fork** button (top right)
3. GitHub will create a copy under your account
4. Then follow this guide to connect your local repository to your fork

### Q: Can I just delete everything and start over?

**A:** You can, but it's not necessary! Following this guide will fix your configuration without losing any work. But if you prefer to start fresh:

1. Back up any changes you've made (copy your code somewhere safe)
2. Delete the local `DEV-110---Introduction-to-Programming-C---W26` folder
3. Fork the instructor's repository on GitHub
4. Clone YOUR fork: `git clone https://github.com/YOUR-USERNAME/DEV-110-...-W26.git`
5. Copy your backed-up code back into the new clone

---

## Quick Reference: Git Remote Commands

```bash
# View current remotes
git remote -v

# Change origin URL
git remote set-url origin <new-url>

# Add a new remote
git remote add <name> <url>

# Remove a remote
git remote remove <name>

# Rename a remote
git remote rename <old-name> <new-name>
```

---

## Still Having Trouble?

1. **Double-check your fork exists** on GitHub.com under your profile
2. **Make sure you copied the correct URL** from your fork (not the instructor's repo)
3. **Post on Canvas discussion board** with:
    - The output of `git remote -v`
    - Any error messages you're seeing
4. **Contact the instructor** or come to office hours

---

## Prevention: How to Avoid This in the Future

When starting a new project from a forked repository:

1. ✅ **Always fork first** on GitHub
2. ✅ **Clone from your fork**, not the original repository
3. ✅ **Check remotes** with `git remote -v` after cloning
4. ✅ **Set up upstream** to get instructor updates

**Remember:** Your workflow should be:
**Instructor's Repo** → **Fork to Your Account** → **Clone Your Fork** → **Work Locally** → **Push to Your Fork**
