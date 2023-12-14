using GHIElectronics.Endpoint.Devices.Adc;
using static GHIElectronics.Endpoint.Core.EPM815;


var adcController = new AdcController(Adc.Pin.PA6);


while (true)
{
    var v = adcController.Read();

    Console.WriteLine(v.ToString());
    Thread.Sleep(10);

}
