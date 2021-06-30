using System.Text;
using System.Reflection;
using UnityEngine;
public class Video : ArObject {
    // HTML properties
    public string scaleX_width { get; set; }
    public string scaleY_height { get; set; }

    public void initialize() {
        HtmlTag = TagNames.video;

        x_pos_offset = -1f/10f;
        y_pos_offset = 1f/10f;
        z_pos_offset = 1f/10f;
        x_rot_offset = 1f;
        y_rot_offset = -1f;
        z_rot_offset = -1f;
        x_scale_offset = 1f;
        y_scale_offset = 1f;
        z_scale_offset = 1f;
    }
}