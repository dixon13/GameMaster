namespace GameMaster.Translators
{
    using Boilerplate;
    using GameMaster.ViewModels;

    public class CarToCarTranslator : ITranslator<Models.Car, Car>
    {
        public void Translate(Models.Car source, Car destination)
        {
            destination.CarId = source.CarId;
            destination.Cylinders = source.Cylinders;
            destination.Make = source.Make;
            destination.Model = source.Model;
        }
    }
}
