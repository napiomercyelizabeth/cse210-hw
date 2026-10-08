// EXCEEDING REQUIREMENTS DESCRIPTION:
// 1. Leveling and RPG Title Progression: Added level progression based on score milestones 
//    (Level = Score / 1000 + 1) with unlocked titles (e.g., Novice Explorer, Apprentice Adventurer, Quest Master, Legendary Hero).
// 2. Bad Habit (Negative) Goals: Added a BadHabitGoal derived class that penalizes points when recorded, allowing users
//    to track bad habits and deduct points when they slip up.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}