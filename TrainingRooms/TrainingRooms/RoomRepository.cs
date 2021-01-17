using System.Collections.Generic;
using System.Linq;

namespace TrainingRooms
{
    public class RoomRepository
    {
        public RoomRepository()
        {

        }

        public List<TrainingRoom> GetRooms() => trainingRooms;

        public TrainingRoom GetRoom(int id) => trainingRooms.FirstOrDefault(it => it.Id == id);

        //

        private readonly List<TrainingRoom> trainingRooms = new List<TrainingRoom>
        {
            new TrainingRoom
            {
                Id = 1,
                Name = "Copernicus",
                Location = "Building 1",
                NumberOfComputers = 25,
            },
            new TrainingRoom
            {
                Id = 2,
                Name = "Sagittarius",
                Location = "Building 1",
                NumberOfComputers = 20,
            },
            new TrainingRoom
            {
                Id = 2,
                Name = "Luna",
                Location = "Building 3",
                NumberOfComputers = 50,
            }
        };
    }
}
