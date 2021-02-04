using System.Collections.Generic;
using System.Linq;

namespace TrainingRooms
{
    public class RoomRepository
    {
        public RoomRepository() { }

        public List<TrainingRoom> GetRooms() => rooms;

        public TrainingRoom GetRoom(int id) => rooms.FirstOrDefault(r => r.Id == id);

        //

        private readonly List<TrainingRoom> rooms =
            new List<TrainingRoom>
            {
                new TrainingRoom{
                    Id = 1,
                    Name = "Copernicus",
                    Location = "Building 1",
                    NumberComputers = 25
                },
                new TrainingRoom{
                    Id = 2,
                    Name = "Sagittarius",
                    Location = "Building 1",
                    NumberComputers = 10
                },
                new TrainingRoom{
                    Id = 3,
                    Name = "Luna",
                    Location = "Building 3",
                    NumberComputers = 50
                }

            };
    }
}
