using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrical_circuit
{
   class Director
  {
       public void Construct(Builder builder, AbstractFactory.Element element)
       {
        builder.BuildProject(element);
       }
  }
 
  
  abstract class Builder
  {
    public abstract void BuildProject(AbstractFactory.Element element);
    public abstract Project GetResult();
  }
 
  
  class BuilderNewProject : Builder
  {
    private Project project = new Project();

    public override void BuildProject(AbstractFactory.Element element)
    {
             project.Add(element);
    }
    public override Project GetResult()
    {
      return project;
    }
  }
  
  class Project
  {
    private List<AbstractFactory.Element> _parts = new List<AbstractFactory.Element>();
 
    public void Add(AbstractFactory.Element part)
    {
      _parts.Add(part);
    }
  }
}
 
