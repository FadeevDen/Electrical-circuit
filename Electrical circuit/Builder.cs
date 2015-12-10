using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrical_circuit
{
   public class Director
  {
       public void Construct(Builder builder, AbstractFactory.Element element)
       {
        builder.BuildProject(element);
       }
  }


    public abstract class Builder
  {
    public abstract void BuildProject(AbstractFactory.Element element);
    public abstract Project GetResult();
  }
 
  
  public class BuilderNewProject : Builder
  {
    public Project project = new Project();

    public override void BuildProject(AbstractFactory.Element element)
    {
      project.Add(element);
    }
    public override Project GetResult()
    {
      return project;
    }
  }
  
  public class Project
  {
    public List<AbstractFactory.Element> ListOfElements = new List<AbstractFactory.Element>();
 
    public void Add(AbstractFactory.Element part)
    {
      ListOfElements.Add(part);
    }
  }
}
 
