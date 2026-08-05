# Claude AI Guidelines
 
This is a website for an IT software consulting business. 
All employees are very experienced software developers and are expected to be able to write code without assistance.

`AGENTS.md` contains the repository-wide guidance; keep shared conventions in this file aligned with it.

## General Instructions
- Limit responses to one sentence especially for explanations.
- Projects in this repository should use the latest C# features.
- Run `dotnet test WildConsulting.WebSite.Core.slnx` after code changes.

## Team Best Practices
- Always create files using file-scoped namespaces.
- When doing auth, use current .NET idioms; auth state is optional and should be disabled by default.
- Prefer inline lambdas over full method bodies in C#.
- Prefer async and await over synchronous code.
- Never use CSS inline styles. Always use a CSS file.
- Use Razor Pages for website UI and keep request logic in the corresponding `PageModel`.
- When creating Web API projects, prefer minimal APIs project.

## Testing Guidelines
- Use xUnit for unit tests.
- Use FluentAssertions version 7.2.0 for assertions.
- Use Moq for mocking.
