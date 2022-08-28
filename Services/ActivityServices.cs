using DevIndoAPI.Models;

namespace DevIndoAPI.Services
{
    public static class ActivityServices
    {
        static List<Activity> Activities = new() {
            new() {
            Date = "sekarang",
                Issues = "issue",
                Description = "desc",
                RuralName = "Oogway" }
        };

        static List<ActiveRural> ActiveRurals = new() {
            new ActiveRural()
        {
            Rural = new Rural("Uma", "Loc1", "10"),ActivitiesCount = 0,VotingScore = 0
        },
              new ActiveRural()
        {
            Rural = new Rural("Rural2", "Loc2", "20"),ActivitiesCount = 0,VotingScore = 0
        },
                new ActiveRural()
        {
            Rural = new Rural("Rural3", "Loc3", "30"),ActivitiesCount = 0,VotingScore = 0
        },
        };

        public static List<Activity> GetVoting()
        {
            return Activities;
        }
        public static List<Activity> GetAllActivity()
        {
            return Activities;
        }
        public static List<ActiveRural> GetActiveRurals()
        {
            return ActiveRurals;
        }
        public static void AddActivity(Activity activity)
        {
            Activities.Add(activity);
        }
    }
}
