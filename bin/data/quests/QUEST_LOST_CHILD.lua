QUEST_LOST_CHILD = {
	title = 'IDS_PROPQUEST_INC_001015',
	character = 'MaSa_Porgo',
	start_requirements = {
		min_level = 20,
		max_level = 30,
		job = { 'JOB_MERCENARY', 'JOB_ACROBAT', 'JOB_ASSIST', 'JOB_MAGICIAN' },
	},
	rewards = {
		gold = 43200,
	},
	dialogs = {
		begin = {
			'IDS_PROPQUEST_INC_001016',
			'IDS_PROPQUEST_INC_001017',
			'IDS_PROPQUEST_INC_001018',
			'IDS_PROPQUEST_INC_001019',
			'IDS_PROPQUEST_INC_001020',
		},
		begin_yes = {
			'IDS_PROPQUEST_INC_001021',
		},
		begin_no = {
			'IDS_PROPQUEST_INC_001022',
		},
		completed = {
			'IDS_PROPQUEST_INC_001023',
		},
		not_finished = {
			'IDS_PROPQUEST_INC_001024',
		},
	}
}