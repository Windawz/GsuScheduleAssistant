namespace GsuScheduleAssistant.Schedules;

public class Schedule
{
    public Schedule(IEnumerable<Slot> slots)
    {
        Slots = slots.ToArray();
    }

    public IReadOnlyCollection<Slot> Slots { get; }
}