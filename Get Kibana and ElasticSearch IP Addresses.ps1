$elasticsearch_ip = docker inspect -f '{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' ek_elasticsearch_1
Start-Process ('http://{0}:9200' -f $elasticsearch_ip)
$kibana_ip = docker inspect -f '{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' ek_kibana_1
Start-Process ('http://{0}:5601' -f $kibana_ip)
