/***************************************************************************
 *
 * $Author: Turley
 * Advanced Nikodemus
 * 
 * "THE BEER-WINE-WARE LICENSE"
 * As long as you retain this notice you can do whatever you want with 
 * this stuff. If we meet some day, and you think this stuff is worth it,
 * you can buy me a beer and Wine in return.
 *
 ***************************************************************************/

using System.Windows.Forms;
using Ultima;
using UoFiddler.Controls.Plugin;
using UoFiddler.Controls.Plugin.Interfaces;
using UoFiddler.Plugin.MapEditor.UserControls;

namespace UoFiddler.Plugin.MapEditor
{
    public class MapEditorPluginBase : PluginBase
    {
        public override string Name { get; } = "MapEditor";

        public override string Description { get; } = "Provides basic map editing capabilities.";

        public override string Author { get; } = "Community";

        public override string Version { get; } = "1.0.0";

        public override IPluginHost Host { get; set; }

        public override void Initialize()
        {
            _ = Files.RootDir;
        }

        public override void Unload()
        {
        }

        public override void ModifyTabPages(TabControl tabControl)
        {
            TabPage page = new TabPage
            {
                Tag = tabControl.TabCount + 1,
                Text = "Map Editor"
            };

            page.Controls.Add(new MapEditorControl
            {
                Dock = DockStyle.Fill
            });
            tabControl.TabPages.Add(page);
        }
    }
}
