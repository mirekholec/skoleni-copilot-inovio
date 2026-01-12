namespace Demolice.Demo05_VisualStudio2026;

public class BrokenService
{
    private readonly ILogger<BrokenService> _logger;

    public BrokenService(ILogger<BrokenService> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// V této metodě je záměrně chyba
    /// Přidat logování do třídy
    /// Vyzkoušet Debug mód
    /// </summary>
    public string GetCode()
    {
        var hexChars = "0123456789ABCDEF";
        var rnd = new Random();
        var result = "";

        for (int i = 0; i < 10; i++)
        {
            int index = rnd.Next(0, hexChars.Length + 1);
            _logger.LogDebug("Vygenerován index: {Index}", index);
            result += hexChars[index];
        }

        _logger.LogInformation("Vygenerovaný kód: {Result}", result);

        return result;
    }
}