using Microsoft.EntityFrameworkCore;
using TrabajoNET.DataAccess;
using TrabajoNET.DTOs;
using TrabajoNET.Entities;
using TrabajoNET.Services;

namespace TrabajoNET.Repository
{
    public class ActivityRepository : Repository<Activity>
    {

        public ActivityRepository(ContextDB contextDB) : base(contextDB)
        {

        }

        public async Task<List<Activity>> GetAllUsers()
        {
            try
            {
                return await _contextDB.Activities.Where(x => x.IsDeleted == false).ToListAsync(); ;
            }
            catch (Exception ex)
            {

                return null;
            }

        }

        public async Task<Activity?> GetUserId(int id)
        {
            try
            {
                return await _contextDB.Activities.Where(x => x.Id == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                return null;
            }

        }

        public async Task<bool> InsertActivity(ActivityRegisterDTO activityRegisterDTO)
        {
            try
            {
                var activities = new Activity();
                activities = activityRegisterDTO;

                return await base.Insert(activities);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> UpdateActivity(ActivityRegisterDTO activityRegisterDTO, int id)
        {
            try
            {
                var activities = new Activity();
                activities = activityRegisterDTO;
                activities.Id = id;
                activities.IsCompleted = activityRegisterDTO.IsCompleted;

                return await base.Update(activities);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteActivity(int id)
        {
            try
            {
                var activities = await GetActivityId(id);
                activity.IsDeleted = true;

                return await base.Update(activity);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
                        
    }
}