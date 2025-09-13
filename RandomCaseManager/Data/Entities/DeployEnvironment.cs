using System.ComponentModel.DataAnnotations;

namespace RandomCaseManager.Data.Entities
{
    public class DeployEnvironment
    {
        [Key]
        public string Name { get; set; }
    }
}
