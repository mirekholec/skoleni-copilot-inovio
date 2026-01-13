# Konfigurační soubory projektu

## .mcp.json

```json
{
	"servers": {
		"CopilotSpaces": {
			"url": "https://api.githubcopilot.com/mcp/x/copilot_spaces",
			"requestInit": {
				"headers": {
					"Authorization": "Bearer YOUR_GITHUB_PAT_TOKEN"
				}
			},
			"type": "http",
			"version": "0.21.1"
		},
		"Playwright": {
			"command": "npx",
			"args": [
				"@playwright/mcp@latest"
			]
		}
	}
}
```

## src/appsettings.json

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "GptEndpoint": "https://skolenigpt.openai.azure.com",
  "GptApiKey": "secrets.json"
}
```

## src/Properties/launchSettings.json

```json
{
  "$schema": "https://json.schemastore.org/launchsettings.json",
    "profiles": {
      "http": {
        "commandName": "Project",
        "dotnetRunMessages": true,
        "launchBrowser": true,
        "applicationUrl": "http://localhost:5029",
        "environmentVariables": {
          "ASPNETCORE_ENVIRONMENT": "Development"
        }
      },
      "https": {
        "commandName": "Project",
        "dotnetRunMessages": true,
        "launchBrowser": true,
        "applicationUrl": "https://localhost:7070;http://localhost:5020",
        "environmentVariables": {
          "ASPNETCORE_ENVIRONMENT": "Development"
        }
      }
    }
  }
```

