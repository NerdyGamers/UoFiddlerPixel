# AGENTS Instructions

- Use ripgrep (`rg`) for searching; avoid `ls -R` or `grep -R`.
- This repository is a .NET solution (`UoFiddler.sln`) targeting .NET 8.
- When modifying code, run `dotnet build UoFiddler.sln` to ensure it compiles.
- There are currently no automated tests.
- Follow the coding conventions in `.editorconfig`:
  - C# files use four-space indentation and CRLF line endings.
  - New C# files must include the Beer-Wine-Ware license header defined in `file_header_template`.
  - Sort `using` directives with system namespaces first.
- Changes that affect documentation only do not require running build or tests.
