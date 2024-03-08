using System.Data;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //-------------------------GUIDS---------------------------
        // //gera  um rash novo
        // var id = Guid.NewGuid();

        // //Posso passar um guid para uma string
        // id.ToString();

        // //Crio um guid de acordo  com a string que eu quero
        // id = new Guid("f469c738-1639-4b3b-87dd-430b190ac926");

        // Console.WriteLine(id);

        //-------------------------DATAS---------------------------
        Console.Clear();
        // //Pega só a estrutura
        //var data = new DateTime();

        // //Pega o dia de hoje
        //var data = DateTime.Now;

        //Colocando uma data especifica (ano, mes, dia, hora, min e sec)
        // var data = new DateTime(2024, 10, 10, 13, 30, 01);
        // Console.WriteLine(data);
        // Console.WriteLine(data.Year);
        // Console.WriteLine(data.Month);
        // Console.WriteLine(data.Day);
        // Console.WriteLine(data.Hour);
        // Console.WriteLine(data.Second);
        // Console.WriteLine(data.Minute);
        // Console.WriteLine(data.DayOfWeek);
        // Console.WriteLine(data.DayOfYear);

        //-------------------------FORMATAÇÃO---------------------------
        // var data = DateTime.Now;
        // var formatada = String.Format("{0:yyyy}", data);
        // var formataMes = String.Format("{0:MM}", data);
        // var formatada1 = String.Format("{0:dd/MM/yyyy HH:mm:ss}", data);
        // Console.WriteLine(formatada);
        // Console.WriteLine(formataMes);
        // Console.WriteLine(formatada1);

        // var data = DateTime.Now;
        // Console.WriteLine(data);
        // Console.WriteLine(data.AddDays(12));
        // Console.WriteLine(data.AddMonths(1));
        // Console.WriteLine(data.AddYears(3));

        //-------------------------CULTURES---------------------------
        // var br = new CultureInfo("pt-BR");
        // var pt = new CultureInfo("pt-PT");
        // var en = new CultureInfo("en-US");
        // var de = new CultureInfo("de-DE");
        // var atual = CultureInfo.CurrentCulture;

        // Console.WriteLine(DateTime.Now.ToString("D",atual));
        // //Console.WriteLine(String.Format("{0}:D", DateTime.Now));

        //-------------------------TIMEZONES---------------------------
        // var dateTime = DateTime.UtcNow;
        // Console.WriteLine(dateTime);
        // Console.WriteLine(dateTime.ToLocalTime());

        // //Encontra o timezone 
        // var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
        // Console.Write(timezoneAustralia);

        // //Pega o horario internacional e soma naquele fuso
        // var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezoneAustralia);
        // Console.WriteLine(horaAustralia);

        // //Se quiser fazer o contrario da proposta de cima
        // var horaAtual = TimeZoneInfo.ConvertTimeToUtc(horaAustralia, timezoneAustralia);
        // Console.WriteLine(horaAtual);

        // //Faz uma lista de todo os timezone
        // var timezones = TimeZoneInfo.GetSystemTimeZones();
        // foreach (var timezone in timezones)
        // {
        //     Console.WriteLine(timezone.Id);
        //     Console.WriteLine(timezone);
        //     Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezone));
        //     Console.WriteLine("_________");
        // }

        //-------------------------TIMESPAN---------------------------
        var timeSpan = new TimeSpan();
        Console.WriteLine(timeSpan);
        //nano segundos
        var timeSpanNanosegundos = new TimeSpan(1);
        Console.WriteLine(timeSpanNanosegundos);
        //hara, min e seg
        var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
        Console.WriteLine(timeSpanHoraMinutoSegundo);
        //dia, hora, min, seg
        var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundo);
        //dia, hora, min, seg e milissegundo
        var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

        //Operações com timespan
        Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

        //-------------------------CONTAS DATAS---------------------------  
        //Saber quantos dias tem no mês
        Console.WriteLine(DateTime.DaysInMonth(2020, 2));

        //Como saber se é fds ou não
        Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));

        //Traz um boleano pra saber se é horario de verão ou não
        Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
    }
    static bool IsWeekend(DayOfWeek today)
    {
        return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
    }

}

