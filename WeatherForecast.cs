using System;

namespace Poc_01
{

    //Inclusão de Comentário, para servir de comparação de alterações no arquivo GIT
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
