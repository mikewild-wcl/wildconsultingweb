# Repository Agent Guidelines

This repository contains the ASP.NET Core Razor Pages website for Wild Consulting Limited, an IT software consultancy.

The intended contributors are experienced software engineers, so prefer concise technical communication and do not explain routine code unless clarification is useful.

`CLAUDE.md` contains equivalent guidance for Claude-based tools; keep shared engineering and testing conventions consistent between both files.

## Project Structure

- The website is in `src/WildConsulting.WebSite.Core` and targets .NET 10.
- Razor Pages and their page models belong under `Pages`.
- Static assets and styles belong under `wwwroot`.
- Unit tests are in `src/WildConsulting.WebSite.Core.Tests`.
- `azure-pipelines.yml` builds, tests, transforms configuration and deploys the website.

## General Instructions

- Limit responses to one sentence where practical, especially for explanations.
- Use the latest C# features supported by the repository.
- Preserve unrelated working-tree changes.
- Keep changes focused and avoid unnecessary abstractions in this small website.
- Run `dotnet test WildConsulting.WebSite.Core.slnx` after code changes.

## Engineering Conventions

- Use file-scoped namespaces for C# files.
- Prefer primary constructors and expression-bodied or inline implementations when they improve clarity.
- Prefer asynchronous APIs with `async` and `await` for I/O operations.
- Use current .NET authentication and authorization idioms; authentication state is optional and disabled by default unless requirements say otherwise.
- Use Razor Pages for website UI and minimal APIs for any new Web API endpoints.
- Never use inline CSS; add styles to a CSS file under `wwwroot`.
- Keep page-specific request logic in the corresponding `PageModel` rather than introducing MVC controllers.
- Do not commit deployment secrets or production configuration values; deployment settings are supplied by Azure Pipeline variable groups.

## Testing Conventions

- Use xUnit for unit tests.
- Use FluentAssertions version 7.2.0 for assertions.
- Use Moq for mocking.
- Name tests after the behavior being verified.
