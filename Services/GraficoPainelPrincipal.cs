using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActivityManagement.Services
{
    public class GraficoPainelPrincipal
    {
        public static string GraficoPizza ()
        {
            string grafico = @"am5.ready(function() {
                    var root = am5.Root.new('chartdiv');

                    root.setThemes([
                    am5themes_Animated.new(root)
                    ]);

                    var chart = root.container.children.push(am5percent.PieChart.new(root, {
                    layout: root.verticalLayout
                    }));

                    var series = chart.series.push(am5percent.PieSeries.new(root, {
                    valueField: 'value',
                    categoryField: 'category'
                    }));

                    series.data.setAll([
                    { value: 10, category: 'One' },
                    { value: 9, category: 'Two' },
                    { value: 6, category: 'Three' },
                    { value: 5, category: 'Four' },
                    { value: 4, category: 'Five' },
                    { value: 3, category: 'Six' },
                    { value: 1, category: 'Seven' },
                    ]);

                    var legend = chart.children.push(am5.Legend.new(root, {
                    centerX: am5.percent(50),
                    x: am5.percent(50),
                    marginTop: 15,
                    marginBottom: 15
                    }));

                    legend.data.setAll(series.dataItems);

                    series.appear(1000, 100);

                    })
                    <div id='chartdiv'></div>;";
            return grafico;
        }
    }
}