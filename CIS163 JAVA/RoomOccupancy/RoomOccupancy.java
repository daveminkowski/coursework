// Created by Dave Minkowski on 11/5/2016

public class RoomOccupancy {

    // # of people in a room
    private int numberInRoom;
    // total # of all people in all rooms combined
    private static int totalNumber = 0;

    //default constructor method sets number of people in a room to 0
    public RoomOccupancy() {
        numberInRoom = 0;
    }

    //method to add one person to a room, increase count of people in this room by 1 and increase count of all people by 1
    public void addOneToRoom() {
        numberInRoom++;
        totalNumber++;
    }
    //method to remove one person from a room but does not go below 0 occupants
    public void removeOneFromRoom() {
        if (canRemove(1)) { // if this statements returns true, then remove 1 from a room and decrease the total count of all occupants by 1.
            numberInRoom--;
            totalNumber--;
        }
    }

    // Access the private variable showing number of people in a room
    public int getNumber() {
        return numberInRoom;
    }

    //Access number of people in all rooms combined
    public static int getTotal() {
        return totalNumber;
    }

    // Value which determines if a room is at 0 occupants, allowing or disallowing removal of one occupant.
    public boolean canRemove(int atLeastOne) {
        return numberInRoom >= atLeastOne; // if the number in the room is >= to 1 (the value we set this variable at in the removeOneFromRoom method) then the boolean is true.
    }

    public static void main(String[] args) {
        // Create any number of rooms (4 in this case) called room1, room2, etc.
        RoomOccupancy lobby = new RoomOccupancy();
        int roomCount = 0; // create an integer to keep track of the number of rooms total.
        roomCount++; // increase the counter for the number of rooms.
        RoomOccupancy conferenceRoom = new RoomOccupancy();
        roomCount++;
        RoomOccupancy office = new RoomOccupancy();
        roomCount++;
        RoomOccupancy warehouse = new RoomOccupancy();
        roomCount++;
        RoomOccupancy breakRoom = new RoomOccupancy();
        roomCount++;

        System.out.println("\nAdding Occupants to " + roomCount + " rooms:\n");

        for (int x = 0; x < 5; x++) // Add occupant to room until occupants = 5, then stop adding occupants. (Change x value to change occupants added)
            lobby.addOneToRoom();
        System.out.println("Adding " + lobby.getNumber() + " to the Lobby. Total in all rooms is now " + RoomOccupancy.getTotal() + ".");

        for (int x = 0; x < 7; x++) // Add occupant to room until occupants = 7, then stop adding occupants (Change x value to change occupants added)
            conferenceRoom.addOneToRoom();
        System.out.println("Adding " + conferenceRoom.getNumber() + " to the Conference Room. Total in all rooms is now " + RoomOccupancy.getTotal() + ".");

        for (int x = 0; x < 3; x++) // Add occupant to room until occupants = 3, then stop adding occupants (Change x value to change occupants added)
            office.addOneToRoom();
        System.out.println("Adding " + office.getNumber() + " to the Office. Total in all rooms is now " + RoomOccupancy.getTotal() + ".");

        for (int x = 0; x < 8; x++) // Add occupant to room until occupants = 8, then stop adding occupants (Change x value to change occupants added)
            warehouse.addOneToRoom();
        System.out.println("Adding " + warehouse.getNumber() + " to the Warehouse. Total in all rooms is now " + RoomOccupancy.getTotal() + ".");

        for (int x = 0; x < 15; x++) // Add occupant to room until occupants = 15, then stop adding occupants (Change x value to change occupants added)
            breakRoom.addOneToRoom();
        System.out.println("Adding " + breakRoom.getNumber() + " to the Break Room. Total in all rooms is now " + RoomOccupancy.getTotal() + ".");

        for (int x = 0; x < 10; x++) { // remove 1 from each room - will remove a maximum of ten occupants with these settings in this loop.
            // if the number in the for loops for each room is greater than 10, the remainder will NOT be removed - the break room demonstrates this.
            lobby.removeOneFromRoom();
            conferenceRoom.removeOneFromRoom();
            office.removeOneFromRoom();
            warehouse.removeOneFromRoom();
            breakRoom.removeOneFromRoom();
        }

        System.out.println("\nRemoving up to 10 Occupants from all rooms:\n");
        System.out.println("Occupants remaining in the Lobby: " + lobby.getNumber() + ". Total remaining in all rooms: " + RoomOccupancy.getTotal() + ".");
        System.out.println("Occupants remaining in the Conference Room: " + conferenceRoom.getNumber() + ". Total remaining in all rooms: " + RoomOccupancy.getTotal());
        System.out.println("Occupants remaining in the Office: " + office.getNumber() + ". Total remaining in all rooms: " + RoomOccupancy.getTotal());
        System.out.println("Occupants remaining in the Warehouse: " + warehouse.getNumber() + ". Total remaining in all rooms: " + RoomOccupancy.getTotal());
        System.out.println("Occupants remaining in the Break Room: " + breakRoom.getNumber() + ". Total remaining in all rooms: " + RoomOccupancy.getTotal());

    }

}