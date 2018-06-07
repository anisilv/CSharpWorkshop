namespace Domain
{
    public class Consultant
    {
        public string Name {get; set;}
        public int Squad {get; set;}
        public string Project {get; set;}
        public string Rol {get; set;}
        public string Id {get; set;}

        public class Builder
        {
            public Builder()
            {
                _instance= new Consultant();
            }
            private Consultant _instance;

            public Builder WithName(string name)
            {
                _instance.Name = name;
                return this;
            }

            public Builder WithSquad(int squad)
            {
                _instance.Squad = squad;
                return this;
            }

            public Builder WithProject(string project)
            {
                _instance.Project = project;
                return this;
            }

            public Builder WithRol(string rol)
            {
                _instance.Project = rol;
                return this;
            }

            public Builder WithId(string id)
            {
                _instance.Id = id;
                return this;
            }

            public Builder WithSquad1AndRolDev()
            {
                _instance.Squad = 1;
                _instance.Rol = "Dev";
                
                return this;
            }
            public Consultant Build()
            {
                return _instance;
            }
        }
    }
}