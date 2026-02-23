using System.Globalization;

namespace System //Colocando o namespace system não preciso ficar importando pois o DateTime já pertence ao system
{
    static class DateTimeExtensions
    {
        // O primeiro parâmetro determina que o método é um método de extensão.
        // O primeiro parâmetro faz referência ao próprio objeto.
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + "Hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + "Days";
            }
        }
    }
}
