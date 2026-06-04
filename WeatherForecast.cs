using System;

namespace Poc_01
{

    //Inclusão de Comentário, para servir de comparação de alterações no arquivo GIT
    //Adição de nova linha de comando.
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        // --- NOVOS COMPORTAMENTOS ---

        /// <summary>
        /// Propriedade calculada que diz se o clima está quente (acima de 25°C).
        /// </summary>
        public bool IsHot => TemperatureC > 25;

        /// <summary>
        /// Método que retorna uma descrição completa e amigável da previsão.
        /// </summary>
        public string GetFullDescription()
        {
            string emoji = IsHot ? "☀️" : "❄️";
            return $"Data: {Date.ToShortDateString()} | Temp: {TemperatureC}°C ({TemperatureF}°F) | Condição: {Summary} {emoji}";
        }

        
       
    }
}
