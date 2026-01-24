# Documentation Conventions

Here are checkmark characters you can use in markdown files:

## Task Lists

### **For Task Lists (GitHub Markdown)**

```markdown
- [ ] Unchecked item
- [x] Checked item
```

### **Standalone Checkmark Characters**

- `✓` - Check mark (U+2713)
- `✔` - Heavy check mark (U+2714)
- `✅` - White heavy check mark emoji (U+2705) ← *You're already using this one*
- `☑` - Ballot box with check (U+2611)
- `✔️` - Check mark emoji

### **Copy-Paste Ready**

```text
✓  Light checkmark
✔  Heavy checkmark  
✅ Emoji checkmark (already in your file)
☑  Ballot box
[x] Task list checked
```

**Recommendation**: For your TODO.md file, use `[x]` in your task lists to mark completed items:

```markdown
1. **High Priority**:
   - [x] Fix rate limiting to respect `Retry-After` header
   - [ ] Remove database connection logic from API client
```

This renders nicely on GitHub and is the standard for markdown task lists.
