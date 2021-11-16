using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace U3_A1
{
    /// <summary>
    /// Interaction logic for Content.xaml
    /// </summary>
    public partial class Content : Page
    {
        private int i;

        string[,] textFieldsArray = { 
            // [1]
            { "Negative Effects of Computer Use On The Environment", "Computer and technology use has various negative effects on the environment, particularly in universities. Computer use wastes a lot of energy; even if your computer is in sleep mode or the monitor is off or even if it's shut down, energy is still consumed if connected to power. Almost all university students own at least 2 electronics such as a cell phone and a laptop; many of these devices are left charging while remaining idle which creates alarming amounts of energy waste which also strains the university’s electrical bills when this money could be spent on improving the university’s environment. Moreover, energy waste results in more greenhouse gas emissions, causing more pollution, further damaging the environment. Lastly, the metals and minerals extracted from the environment to make computers also heavily damage the environment as most disposed computers just end up in landfills unable to be reused.", "By Bob" },
            // [5]
            { "Measures To Reduce Environmental Impact of Computers", "There are many preventative measures to reduce the negative impacts of computer use on the environment. Firstly, to reduce energy waste and consumption, completely shut down your computer and turn off the monitor when not in use. Unplug the power cords from the wall outlet when not in use because computers still use “phantom power” even when they are shut down. Furthermore, consider buying environmentally friendly and efficient computer devices that leave less impact on the environment. Secondly, universities can set policies to limit the amount of paper that can be printed for each computer in a day to reduce the amount of paper waste and to promote sharing information electronically. Lastly, universities and students should dispose of electronics responsibly by contacting specific electronic disposal facilities instead of throwing them in the trash which ends up in landfills.", "By Bob" },
            
            // [3]
            { "Negative Effects of Computer Use On Human Health", "Excessive computer use by University Students can cause a variety of health issues that will hamper their ability to perform well in an academic environment. The negative Psychological effects of excessive computer use include feelings of isolation, lack of motivation, and amplified stress. The negative physical effects include eye strain, migraines, headaches, sleep problems. A number of problems can also be tied to excessive computer use, as this indirectly implies a lack of time spent in other activities: back and neck strain and obesity from a sedentary lifestyle.", "By Arjun" },
            
            // [3] 
            { "Measures To Reduce Human Health Impact of Computers", "Measures that can reduce the impact of computers on a University Student’s health include setting screen time limits, practicing extracurriculars and hobbies that don’t involve a screen, participating in organized physical activity, taking regular active breaks from the screen every half hour, adjusting the lighting in the room a screen is used in, keeping an appropriate distance between yourself and a screen, as well as taking eye drops.", "By Arjun" },
            // [2]
            { "Computers To Support Environmental Protection", "Computers play a great role in managing resource use and in solutions that implement environmental protection measures in universities. Universities can use computer programs on their mainframe computers and printers to limit and manage power use and printer usage to reduce energy and paper waste. Furthermore, computers can also be used to establish smart systems within the university that automatically implement energy-saving plans on all of the campus devices ranging from computers to HVAC systems.", "By Bob" },
            // [4]
            { "Guidance & Resources For Environmental Stewardship", "Locally, Ottawa has a waste program specifically for eWaste: “Take it Back!” The program works with local retailers and charity organizations to dispose of eWaste in an efficient and clean manner. To find more information on where “drop off zones” are located, however, most are at public centres and schools. By taking the time to drop off your eWaste at drop offs, you can be sure that it is not directly being dumped in a landfill. Certain components in eWaste can be recycled, and hold a lot of value in terms of re-usability", "By Arjun" }
        };

        public Content(int index)
        {
            i = index;
            InitializeComponent();
            titleLabel.Content = textFieldsArray[i, 0];
            contentTB.Text = textFieldsArray[i, 1];
            authorLabel.Content = textFieldsArray[i, 2];
        }

        private void titleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }


        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void backBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());



        }
    }
}

/*
Bibliography

[5] “Electronics Recycling in Ottawa,” Recycle My Electronics Ontario, 28-Jun-2021. [Online]. Available: https://www.recyclemyelectronics.ca/on/ottawa/. [Accessed: 15-Nov-2021].
[1] “Environmental effects,” Isaac Computer Science. [Online]. Available: https://isaaccomputerscience.org/concepts/sys_hard_environment?examBoard=all&stage=all. [Accessed: 15-Nov-2021].
[3] “Eye health in the digital age: Does too much screen time hurt your vision? - UAB medicine news,” Eye Health in the Digital Age: Does Too Much Screen Time Hurt Your Vision? - UAB Medicine News - UAB Medicine. [Online]. Available: https://www.uabmedicine.org/-/eye-health-in-the-digital-age-does-too-much-screen-time-hurt-your-vision-#:~:text=Digital%20eyestrain%20often%20leads%20to,the%20surface%20of%20the%20eye. [Accessed: 15-Nov-2021].
[2] “Minimize your computer's impact on the environment,” Indiana University Knowledge Base, 21-Sep-2021. [Online]. Available: https://kb.iu.edu/d/erth. [Accessed: 15-Nov-2021].
[4] Public Works and Environmental Services Dept., “Take it back! program,” City of Ottawa, 15-Aug-2018. [Online]. Available: https://ottawa.ca/en/business/get-help-starting-or-growing-your-business/programs-and-projects/take-it-back-program. [Accessed: 15-Nov-2021]. 
*/