namespace GsuScheduleAssistant.Schedules;

public record Slot(
    Class Class,
    SubGroup SubGroup,
    TimeOnly StartTime,
    TimeSpan Duration,
    bool IsAboveTheLine);