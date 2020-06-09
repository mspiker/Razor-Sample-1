# Lessons Learned in this Project
## _ViewImports
If you find that you need to provide the full namespace with objects referenced in the cshtml page then you will want to edit the _ViewImports which allow you to reference the classes.  
```cshtml
@using MyProject
@using MyProject.Models
@using MyProject.Models.Enums
@namespace MyProject.Pages
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
```
## Multi-select check boxes
To bind checkboxes where multiple selection can be made is not trivial in Razor.  In this use-case I needed to populate a list of check boxes with an enumerated list, then select the onese saved upon load and get the nexly selected ones bac in a POST.
### Enumeration
Below is the enumeration I want to display.
```c#
using System.ComponentModel.DataAnnotations;

namespace MyProject.Models.Enum
{
  public enum Topics
  {
    [Display(Name = "Programming")]
    Programming = 1,
    [Display(Name = "Meteorology")]
    Meto = 2,
    [Display(Name = "Star Wars")]
    StarWars = 3
  }
}
```
### Page Model
We will first make a property available to hold the list.  
```c#
[BindProperty]
public List<Topics> TopicList { get; set; }
```
When the page posts back we can then simply set the property of the repository class with the user selections.
```c#
public IActionResult OnPost()
{
  if (ModelState.IsValid)
  {
    Item.TopicsList = TopicList;
  }
  return Page();
}
```
### CSHTML
Now that we have our page model ready, lets focus on the HTML.
```cshtml
<label class="col-form-label col-form-label-lg">Topics to pick from</label>
@foreach (Topics topic in Enum.GetValues(typeof(Topics)))
{
  var topicId = (int)topic;
  var topicDisplay = Services.EnumHelper<Topics>.GetDisplayValue(topic);
  var topicSelected = (Model.Item.Topics.Contains(topic) ? "checked" : "");
  <div class="form-check">
    <label class="form-check-label">
      <input class="form-check-input" name="Topics" type="checkbox" value="@topicId" @topicSelected />
      @topicDisplay
    </label>
  </div>
}
```
