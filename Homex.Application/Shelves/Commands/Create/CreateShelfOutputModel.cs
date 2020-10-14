namespace Homex.Application.Shelves.Commands.Create
{
    public class CreateShelfOutputModel
    {
        public CreateShelfOutputModel(int carAdId)
            => this.CarAdId = carAdId;

        public int CarAdId { get; }
    }
}
