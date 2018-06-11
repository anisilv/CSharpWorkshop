using Domain;

namespace CollectionInterfaces.Test
{
    public class ProjectTest : Project
    {
        public class Builder
        {
            Project _instance;
            public Builder()
            {
                _instance = new Project();
            }

            public Builder WithName(string name)
            {
                _instance.Name = name;
                return this;
            }

            public Builder WithCode(string code)
            {
                _instance.Code = code;
                return this;
            }

            public Project Build()
            {
                return _instance;
            }
        }
    }
}